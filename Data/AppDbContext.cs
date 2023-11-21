using Data.Entities;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<OrganizationEntity> Organizations { get; set; }

        private string DbPath { get; set; }

        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "contacts.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactEntity>()
                .HasOne(c => c.Ogranization)
                .WithMany(o => o.Contacts)
                .HasForeignKey(c => c.OrganizationId);

            modelBuilder.Entity<BookEntity>()
                .HasOne(b => b.LiteraryGenre)
                .WithMany(l => l.Books)
                .HasForeignKey(b => b.LiteraryGenreId);


            modelBuilder.Entity<OrganizationEntity>()
                .HasData(
                    new OrganizationEntity()
                    {
                        Id = 1,
                        Name = "WSEI",
                        Description = "Uczelnia",
                    },
                    new OrganizationEntity()
                    {
                        Id = 2,
                        Name = "PJTAK",
                        Description = "Uczelnia"
                    },
                    new OrganizationEntity()
                    {
                        Id = 3,
                        Name = "ABB",
                        Description = "Korporacja"
                    },
                    new OrganizationEntity()
                    {
                        Id = 4,
                        Name = "Technikum Informatyczne w Poznaniu",
                        Description = "Szkoła średnia"
                    }


                ); ;

            modelBuilder.Entity<LiteraturyGenreEntity>()
                .HasData(
                    new LiteraturyGenreEntity()
                    {
                        Id = 1,
                        Genre = "Powieść",
                        Type = "Audiobook",
                    },
                    new LiteraturyGenreEntity()
                    {
                        Id = 2,
                        Genre = "Kryminał",
                        Type = "Ebook",
                    },
                    new LiteraturyGenreEntity()
                    {
                        Id = 3,
                        Genre = "Przygodowa",
                        Type = "Poradnik",
                    },
                    new LiteraturyGenreEntity()
                    {
                        Id = 4,
                        Genre = "Horror",
                        Type = "Książka",
                    }


                ); ;


            //dodanie kontaktów
            modelBuilder.Entity<ContactEntity>().HasData(
                new ContactEntity() { Id = 1, Name = "Adam", Email = "adam@wsei.edu.pl", Phone = "127813268163", Birth = new DateTime(2000, 10, 10), Priority = 1, Created = DateTime.Now, OrganizationId = 1 },
                new ContactEntity() { Id = 2, Name = "Ewa", Email = "ewa@wsei.edu.pl", Phone = "293443823478", Birth = new DateTime(1999, 8, 10), Priority = 2, Created = DateTime.Now, OrganizationId = 3 }
            );
            //zwiazek między klasą a encją, złączenie encji i pola klasy 
            modelBuilder.Entity<OrganizationEntity>()
                .OwnsOne(o => o.Adress)
                .HasData(
                new { OrganizationEntityId = 1, City = "Kraków", Street = "Św. Filipa 17", PostalCode = "31-150" },
                new { OrganizationEntityId = 2, City = "Warszawa", Street = "Aleje Jerozolimskie 120", PostalCode = "00-001" },
                new { OrganizationEntityId = 3, City = "Gdańsk", Street = "ul. Długa 10", PostalCode = "80-001" },
                new { OrganizationEntityId = 4, City = "Poznań", Street = "Stary Rynek 1", PostalCode = "61-001" }
           
               );
        }


        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
                {
                    if (entry.Entity is ContactEntity contact && contact.Created == default)
                    {
                        contact.Created = DateTime.Now;
                    }
                }
            }

            return base.SaveChanges();
        }
    }
}