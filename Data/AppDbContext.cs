using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<BookEntity> Books { get; set; }
        public DbSet<OrganizationEntity> Organizations { get; set; }
        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "contacts.db");
            DbPath = System.IO.Path.Join(path, "books.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactEntity>().HasOne(c => c.Organization).WithMany(o => o.Contacts).HasForeignKey(c => c.OrgaznizationId);

            modelBuilder.Entity<OrganizationEntity>().HasData(new OrganizationEntity() { Id = 1, Name = "WSEI", Description = "Uczelnia wyższa w Krakowie" });

            modelBuilder.Entity<ContactEntity>().HasData(
                new ContactEntity() { Id = 1, Name = "Adam", Email = "adam@wsei.edu.pl", Phone = "127813268163", Birth = new DateTime(2000, 10, 10), Priority = 1, OrgaznizationId = 1 },
                new ContactEntity() { Id = 2, Name = "Ewa", Email = "ewa@wsei.edu.pl", Phone = "293443823478", Birth = new DateTime(1999, 8, 10), Priority = 2, OrgaznizationId = 1 }

            );

            modelBuilder.Entity<BookEntity>().HasData(
                new BookEntity() { BookId = 1, Title = "Jebanie", Page_no = "1500", ISBN = "12312534", PublicationDate = new DateTime(2000, 10, 10), PublishingHouse = "czarnuszki", Priority = 1 },
                new BookEntity() { BookId = 2, Title = "Some Other Book", Page_no = "200", ISBN = "567890", PublicationDate = new DateTime(2005, 5, 5), PublishingHouse = "murzynki", Priority = 2 }
            );


            modelBuilder.Entity<OrganizationEntity>().OwnsOne(o => o.Address).HasData(new { OrganizationEntityId = 1, City = "Kraków", Street = "Św. Filipa 17", PostalCode = "31-150" });
        }
    }
}