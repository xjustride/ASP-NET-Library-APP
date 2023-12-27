using Data.Entities;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<OrganizationEntity> Organizations { get; set; }
        public DbSet<BookEntity> Books { get; set; }
        public DbSet<LibraryEntity> Libraries { get; set; }

        private string DbPath { get; set; }

        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "asplab.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookEntity>()
                .HasOne(b => b.Library)
                .WithMany(l => l.Books)
                .HasForeignKey(b => b.LibraryId);

           


            base.OnModelCreating(modelBuilder);
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            var user = new IdentityUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "test@test.pl",
                NormalizedUserName = "TEST@TEST.PL",
                Email = "test@test.pl",
                NormalizedEmail = "TEST@TEST.PL",
                EmailConfirmed = true,
            };

            user.PasswordHash = ph.HashPassword(user, "abc1234!");
            modelBuilder.Entity<IdentityUser>()
                .HasData(
                    user
                );

            base.OnModelCreating(modelBuilder);
            var adminek = new IdentityUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "adminek@wp.pl",
                Email = "adminek@wp.pl",
                EmailConfirmed = true,
            };

            adminek.PasswordHash = ph.HashPassword(adminek, "Remekremek321@");
            modelBuilder.Entity<IdentityUser>()
                .HasData(
                    adminek
                );


            var adminRole = new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "admin",
                NormalizedName = "ADMIN",
            };

            modelBuilder.Entity<IdentityRole>()
                .HasData(
                adminRole
                );
            
            adminRole.ConcurrencyStamp = adminRole.Id;

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(
                    new IdentityUserRole<string>()
                    {
                        RoleId = adminRole.Id,
                        UserId = user.Id
                    }
                );

            modelBuilder.Entity<ContactEntity>()
                .HasOne(c => c.Ogranization)
                .WithMany(o => o.Contacts)
                .HasForeignKey(c => c.OrganizationId);


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


                );

            modelBuilder.Entity<LibraryEntity>()
                .HasData(
                    new LibraryEntity()
                    {
                        Id = 1,
                        Name = "Biblioteka Główna WSEI",
                        Description = "Główna biblioteka na terenie Wyższej Szkoły Ekonomii i Informatyki",
                        
                    },
                    new LibraryEntity()
                    {
                        Id = 2,
                        Name = "Biblioteka Publiczna PJTAK",
                        Description = "Biblioteka publiczna przy Polsko-Japońskiej Akademii Technik Komputerowych",
                    },
                    new LibraryEntity()
                    {
                        Id = 3,
                        Name = "Biblioteka ABB",
                        Description = "Biblioteka korporacyjna ABB",
                    },
                    new LibraryEntity()
                    {
                        Id = 4,
                        Name = "Biblioteka Technikum Informatycznego w Poznaniu",
                        Description = "Biblioteka szkolna przy Technikum Informatycznym w Poznaniu",
                    }
                );

            modelBuilder.Entity<BookEntity>().HasData(
             new BookEntity()
             {
                 Id = 1,
                 Title = "Przykładowa Książka 1",
                 Page_No = "200",
                 Author = "Jan Brzechwa",
                 ISBN = "12345678",
                 PublicationDate = new DateTime(2022, 1, 1),
                 PublishingHouse = "Wydawnictwo ABC",
                 Priority = 1,
                 Created = DateTime.Now,
                 LibraryId = 1 // Upewnij się, że to Id biblioteki istnieje w danych testowych dla bibliotek
             });
            modelBuilder.Entity<BookEntity>().HasData(
            new BookEntity()
            {
                Id = 2,
                Title = "Przykładowa Książka 1",
                Page_No = "200",
                Author = "Jan Brzechwa",
                ISBN = "12345678",
                PublicationDate = new DateTime(2022, 1, 1),
                PublishingHouse = "Wydawnictwo ABC",
                Priority = 1,
                Created = DateTime.Now,
                LibraryId = 1 // Upewnij się, że to Id biblioteki istnieje w danych testowych dla bibliotek
            });
            modelBuilder.Entity<BookEntity>().HasData(
            new BookEntity()
            {
                Id = 3,
                Title = "Przykładowa Książka 1",
                Page_No = "200",
                Author = "Jan Brzechwa",
                ISBN = "12345678",
                PublicationDate = new DateTime(2022, 1, 1),
                PublishingHouse = "Wydawnictwo ABC",
                Priority = 1,
                Created = DateTime.Now,
                LibraryId = 1 // Upewnij się, że to Id biblioteki istnieje w danych testowych dla bibliotek
            });
            modelBuilder.Entity<BookEntity>().HasData(
            new BookEntity()
            {
                Id = 4,
                Title = "Przykładowa Książka 1",
                Page_No = "200",
                Author = "Jan Brzechwa",
                ISBN = "12345678",
                PublicationDate = new DateTime(2022, 1, 1),
                PublishingHouse = "Wydawnictwo ABC",
                Priority = 1,
                Created = DateTime.Now,
                LibraryId = 1 // Upewnij się, że to Id biblioteki istnieje w danych testowych dla bibliotek
            });
            modelBuilder.Entity<BookEntity>().HasData(
            new BookEntity()
            {
                Id = 5,
                Title = "Przykładowa Książka 1",
                Page_No = "200",
                Author = "Jan Brzechwa",
                ISBN = "12345678",
                PublicationDate = new DateTime(2022, 1, 1),
                PublishingHouse = "Wydawnictwo ABC",
                Priority = 1,
                Created = DateTime.Now,
                LibraryId = 1 // Upewnij się, że to Id biblioteki istnieje w danych testowych dla bibliotek
            });
            modelBuilder.Entity<BookEntity>().HasData(
            new BookEntity()
            {
                Id = 6,
                Title = "Przykładowa Książka 1",
                Page_No = "200",
                Author = "Jan Brzechwa",
                ISBN = "12345678",
                PublicationDate = new DateTime(2022, 1, 1),
                PublishingHouse = "Wydawnictwo ABC",
                Priority = 1,
                Created = DateTime.Now,
                LibraryId = 1 // Upewnij się, że to Id biblioteki istnieje w danych testowych dla bibliotek
            });
            modelBuilder.Entity<BookEntity>().HasData(
            new BookEntity()
            {
                Id = 7,
                Title = "Przykładowa Książka 1",
                Page_No = "200",
                Author = "Jan Brzechwa",
                ISBN = "12345678",
                PublicationDate = new DateTime(2022, 1, 1),
                PublishingHouse = "Wydawnictwo ABC",
                Priority = 1,
                Created = DateTime.Now,
                LibraryId = 1 // Upewnij się, że to Id biblioteki istnieje w danych testowych dla bibliotek
            });
            modelBuilder.Entity<BookEntity>().HasData(
            new BookEntity()
            {
                Id = 8,
                Title = "Przykładowa Książka 1",
                Page_No = "200",
                Author = "Jan Brzechwa",
                ISBN = "12345678",
                PublicationDate = new DateTime(2022, 1, 1),
                PublishingHouse = "Wydawnictwo ABC",
                Priority = 1,
                Created = DateTime.Now,
                LibraryId = 1 // Upewnij się, że to Id biblioteki istnieje w danych testowych dla bibliotek
            });


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

            modelBuilder.Entity<LibraryEntity>()
    .OwnsOne(o => o.LibraryAdress)
                .HasData(
        new { LibraryEntityId = 1, Name = "Biblioteka Główna WSEI", Description = "Główna biblioteka na terenie Wyższej Szkoły Ekonomii i Informatyki"},
        new { LibraryEntityId = 2, Name = "Biblioteka Publiczna PJTAK", Description = "Biblioteka publiczna przy Polsko-Japońskiej Akademii Technik Komputerowych" },
        new { LibraryEntityId = 3, Name = "Biblioteka ABB", Description = "Biblioteka korporacyjna ABB" },
        new  { LibraryEntityId = 4, Name = "Biblioteka Technikum Informatycznego w Poznaniu", Description = "Biblioteka szkolna przy Technikum Informatycznym w Poznaniu" }
    

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
                    else if (entry.Entity is BookEntity book && book.Created == default)
                    {
                        book.Created = DateTime.Now;
                    }
                }
            }

            return base.SaveChanges();
        }
    }
}