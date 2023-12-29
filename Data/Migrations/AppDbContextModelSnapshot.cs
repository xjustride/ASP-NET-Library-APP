﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Data.Entities.BookEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("LibraryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Page_No")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("PublicationDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("publication_date");

                    b.Property<string>("PublishingHouse")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LibraryId");

                    b.ToTable("books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Jan Brzechwa",
                            Created = new DateTime(2023, 12, 29, 14, 26, 2, 451, DateTimeKind.Local).AddTicks(7469),
                            ISBN = "12345678",
                            LibraryId = 1,
                            Page_No = "200",
                            Priority = 1,
                            PublicationDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublishingHouse = "Wydawnictwo ABC",
                            Title = "Przykładowa Książka 1"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Jan Brzechwa",
                            Created = new DateTime(2023, 12, 29, 14, 26, 2, 451, DateTimeKind.Local).AddTicks(7514),
                            ISBN = "12345678",
                            LibraryId = 1,
                            Page_No = "200",
                            Priority = 1,
                            PublicationDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublishingHouse = "Wydawnictwo ABC",
                            Title = "Przykładowa Książka 1"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Jan Brzechwa",
                            Created = new DateTime(2023, 12, 29, 14, 26, 2, 451, DateTimeKind.Local).AddTicks(7524),
                            ISBN = "12345678",
                            LibraryId = 1,
                            Page_No = "200",
                            Priority = 1,
                            PublicationDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublishingHouse = "Wydawnictwo ABC",
                            Title = "Przykładowa Książka 1"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Jan Brzechwa",
                            Created = new DateTime(2023, 12, 29, 14, 26, 2, 451, DateTimeKind.Local).AddTicks(7533),
                            ISBN = "12345678",
                            LibraryId = 1,
                            Page_No = "200",
                            Priority = 1,
                            PublicationDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublishingHouse = "Wydawnictwo ABC",
                            Title = "Przykładowa Książka 1"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Jan Brzechwa",
                            Created = new DateTime(2023, 12, 29, 14, 26, 2, 451, DateTimeKind.Local).AddTicks(7542),
                            ISBN = "12345678",
                            LibraryId = 1,
                            Page_No = "200",
                            Priority = 1,
                            PublicationDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublishingHouse = "Wydawnictwo ABC",
                            Title = "Przykładowa Książka 1"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Jan Brzechwa",
                            Created = new DateTime(2023, 12, 29, 14, 26, 2, 451, DateTimeKind.Local).AddTicks(7553),
                            ISBN = "12345678",
                            LibraryId = 1,
                            Page_No = "200",
                            Priority = 1,
                            PublicationDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublishingHouse = "Wydawnictwo ABC",
                            Title = "Przykładowa Książka 1"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Jan Brzechwa",
                            Created = new DateTime(2023, 12, 29, 14, 26, 2, 451, DateTimeKind.Local).AddTicks(7563),
                            ISBN = "12345678",
                            LibraryId = 1,
                            Page_No = "200",
                            Priority = 1,
                            PublicationDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublishingHouse = "Wydawnictwo ABC",
                            Title = "Przykładowa Książka 1"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Jan Brzechwa",
                            Created = new DateTime(2023, 12, 29, 14, 26, 2, 451, DateTimeKind.Local).AddTicks(7572),
                            ISBN = "12345678",
                            LibraryId = 1,
                            Page_No = "200",
                            Priority = 1,
                            PublicationDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublishingHouse = "Wydawnictwo ABC",
                            Title = "Przykładowa Książka 1"
                        });
                });

            modelBuilder.Entity("Data.Entities.BorrowEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BorrowDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Borrows");
                });

            modelBuilder.Entity("Data.Entities.ContactEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Birth")
                        .HasColumnType("TEXT")
                        .HasColumnName("birth_date");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasMaxLength(12)
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birth = new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2023, 12, 29, 14, 26, 2, 451, DateTimeKind.Local).AddTicks(7583),
                            Email = "adam@wsei.edu.pl",
                            Name = "Adam",
                            OrganizationId = 1,
                            Phone = "127813268163",
                            Priority = 1
                        },
                        new
                        {
                            Id = 2,
                            Birth = new DateTime(1999, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2023, 12, 29, 14, 26, 2, 451, DateTimeKind.Local).AddTicks(7586),
                            Email = "ewa@wsei.edu.pl",
                            Name = "Ewa",
                            OrganizationId = 3,
                            Phone = "293443823478",
                            Priority = 2
                        });
                });

            modelBuilder.Entity("Data.Entities.OrganizationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("organizations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Uczelnia",
                            Name = "WSEI"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Uczelnia",
                            Name = "PJTAK"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Korporacja",
                            Name = "ABB"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Szkoła średnia",
                            Name = "Technikum Informatyczne w Poznaniu"
                        });
                });

            modelBuilder.Entity("LibraryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Libraries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Główna biblioteka na terenie Wyższej Szkoły Ekonomii i Informatyki",
                            Name = "Biblioteka Główna WSEI"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Biblioteka publiczna przy Polsko-Japońskiej Akademii Technik Komputerowych",
                            Name = "Biblioteka Publiczna PJTAK"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Biblioteka korporacyjna ABB",
                            Name = "Biblioteka ABB"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Biblioteka szkolna przy Technikum Informatycznym w Poznaniu",
                            Name = "Biblioteka Technikum Informatycznego w Poznaniu"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "5ef606b6-c35a-47d2-8cb6-9f442c21b1cb",
                            ConcurrencyStamp = "5ef606b6-c35a-47d2-8cb6-9f442c21b1cb",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "eba14ef7-2de8-46d0-a26f-0f73fdf59557",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6377b5f0-71c7-4e54-873c-c965695b35d6",
                            Email = "test@test.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "TEST@TEST.PL",
                            NormalizedUserName = "TEST@TEST.PL",
                            PasswordHash = "AQAAAAEAACcQAAAAEKgZjyBQQVKSVyoMGUy0N41DT71lYBEsFK1igmJ/Zl/1S7aHtG0YomCVYn5F00bhAA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fd86945e-76f4-4f8d-809a-379c686094c1",
                            TwoFactorEnabled = false,
                            UserName = "test@test.pl"
                        },
                        new
                        {
                            Id = "bd689772-7f48-405c-bb6c-8539dfc90ba5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0269b6bd-9cc4-446e-b82f-771c7c13699f",
                            Email = "adminek@wp.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEN7N8bvADtps/lR4u+QTFnw+qztLlee6B00QTTXdcc6EC8r4VmtMe8DeyBgyuXwcoQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d48a0105-b47f-4cf3-8e19-cf45a4dd88e3",
                            TwoFactorEnabled = false,
                            UserName = "adminek@wp.pl"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "eba14ef7-2de8-46d0-a26f-0f73fdf59557",
                            RoleId = "5ef606b6-c35a-47d2-8cb6-9f442c21b1cb"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Data.Entities.BookEntity", b =>
                {
                    b.HasOne("LibraryEntity", "Library")
                        .WithMany("Books")
                        .HasForeignKey("LibraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Library");
                });

            modelBuilder.Entity("Data.Entities.BorrowEntity", b =>
                {
                    b.HasOne("Data.Entities.BookEntity", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.Entities.ContactEntity", b =>
                {
                    b.HasOne("Data.Entities.OrganizationEntity", "Ogranization")
                        .WithMany("Contacts")
                        .HasForeignKey("OrganizationId");

                    b.Navigation("Ogranization");
                });

            modelBuilder.Entity("Data.Entities.OrganizationEntity", b =>
                {
                    b.OwnsOne("Data.Models.Address", "Adress", b1 =>
                        {
                            b1.Property<int>("OrganizationEntityId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("City")
                                .HasColumnType("TEXT");

                            b1.Property<string>("PostalCode")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street")
                                .HasColumnType("TEXT");

                            b1.HasKey("OrganizationEntityId");

                            b1.ToTable("organizations");

                            b1.WithOwner()
                                .HasForeignKey("OrganizationEntityId");

                            b1.HasData(
                                new
                                {
                                    OrganizationEntityId = 1,
                                    City = "Kraków",
                                    PostalCode = "31-150",
                                    Street = "Św. Filipa 17"
                                },
                                new
                                {
                                    OrganizationEntityId = 2,
                                    City = "Warszawa",
                                    PostalCode = "00-001",
                                    Street = "Aleje Jerozolimskie 120"
                                },
                                new
                                {
                                    OrganizationEntityId = 3,
                                    City = "Gdańsk",
                                    PostalCode = "80-001",
                                    Street = "ul. Długa 10"
                                },
                                new
                                {
                                    OrganizationEntityId = 4,
                                    City = "Poznań",
                                    PostalCode = "61-001",
                                    Street = "Stary Rynek 1"
                                });
                        });

                    b.Navigation("Adress")
                        .IsRequired();
                });

            modelBuilder.Entity("LibraryEntity", b =>
                {
                    b.OwnsOne("Data.Models.LibraryAddress", "LibraryAdress", b1 =>
                        {
                            b1.Property<int>("LibraryEntityId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("City")
                                .HasColumnType("TEXT");

                            b1.Property<string>("PostalCode")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street")
                                .HasColumnType("TEXT");

                            b1.HasKey("LibraryEntityId");

                            b1.ToTable("Libraries");

                            b1.WithOwner()
                                .HasForeignKey("LibraryEntityId");

                            b1.HasData(
                                new
                                {
                                    LibraryEntityId = 1
                                },
                                new
                                {
                                    LibraryEntityId = 2
                                },
                                new
                                {
                                    LibraryEntityId = 3
                                },
                                new
                                {
                                    LibraryEntityId = 4
                                });
                        });

                    b.Navigation("LibraryAdress")
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.OrganizationEntity", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("LibraryEntity", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
