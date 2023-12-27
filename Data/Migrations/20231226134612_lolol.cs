using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class lolol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Libraries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    LibraryAdress_City = table.Column<string>(type: "TEXT", nullable: true),
                    LibraryAdress_Street = table.Column<string>(type: "TEXT", nullable: true),
                    LibraryAdress_PostalCode = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libraries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Adress_City = table.Column<string>(type: "TEXT", nullable: true),
                    Adress_Street = table.Column<string>(type: "TEXT", nullable: true),
                    Adress_PostalCode = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Page_No = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ISBN = table.Column<string>(type: "TEXT", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: true),
                    publication_date = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PublishingHouse = table.Column<string>(type: "TEXT", nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    LibraryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_books_Libraries_LibraryId",
                        column: x => x.LibraryId,
                        principalTable: "Libraries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 12, nullable: true),
                    birth_date = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    OrganizationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_contacts_organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "organizations",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e6d16494-736c-419c-87da-06338980002b", "e6d16494-736c-419c-87da-06338980002b", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2ef89e76-a515-422b-a3e0-c19e55cab97c", 0, "56b53807-393b-424a-8f5c-c5f349ce98dd", "test@test.pl", true, false, null, "TEST@TEST.PL", "TEST@TEST.PL", "AQAAAAEAACcQAAAAEKn/iLAHk0+kpb9jF2ddRQ1x6IgdhWGS/cBzon07xWa6mYbvodpql6Y+MCBEs1yxng==", null, false, "9980a5b9-1066-4049-b5c8-24d1fdaa59bf", false, "test@test.pl" },
                    { "9182b210-1e5e-4633-b534-6e12193f8cab", 0, "ce81bd97-fb69-409c-9904-3b2c1a954e41", "adminek@wp.pl", true, false, null, null, null, "AQAAAAEAACcQAAAAEGz6qlKK2ur4Un7TgOpz8mHOm3aJi6BfEqbw+S/b7tY+DVMGJ0W3eNwR7SDEWNTisw==", null, false, "6c143b10-6e14-4950-94d4-fdc084bd6ffb", false, "adminek@wp.pl" }
                });

            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "Id", "LibraryAdress_City", "LibraryAdress_PostalCode", "LibraryAdress_Street", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, null, null, "Główna biblioteka na terenie Wyższej Szkoły Ekonomii i Informatyki", "Biblioteka Główna WSEI" },
                    { 2, null, null, null, "Biblioteka publiczna przy Polsko-Japońskiej Akademii Technik Komputerowych", "Biblioteka Publiczna PJTAK" },
                    { 3, null, null, null, "Biblioteka korporacyjna ABB", "Biblioteka ABB" },
                    { 4, null, null, null, "Biblioteka szkolna przy Technikum Informatycznym w Poznaniu", "Biblioteka Technikum Informatycznego w Poznaniu" }
                });

            migrationBuilder.InsertData(
                table: "organizations",
                columns: new[] { "Id", "Description", "Name", "Adress_City", "Adress_PostalCode", "Adress_Street" },
                values: new object[,]
                {
                    { 1, "Uczelnia", "WSEI", "Kraków", "31-150", "Św. Filipa 17" },
                    { 2, "Uczelnia", "PJTAK", "Warszawa", "00-001", "Aleje Jerozolimskie 120" },
                    { 3, "Korporacja", "ABB", "Gdańsk", "80-001", "ul. Długa 10" },
                    { 4, "Szkoła średnia", "Technikum Informatyczne w Poznaniu", "Poznań", "61-001", "Stary Rynek 1" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e6d16494-736c-419c-87da-06338980002b", "2ef89e76-a515-422b-a3e0-c19e55cab97c" });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "Id", "Author", "Created", "ISBN", "LibraryId", "Page_No", "Priority", "publication_date", "PublishingHouse", "Title" },
                values: new object[,]
                {
                    { 1, "Jan Brzechwa", new DateTime(2023, 12, 26, 14, 46, 11, 973, DateTimeKind.Local).AddTicks(6794), "12345678", 1, "200", 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wydawnictwo ABC", "Przykładowa Książka 1" },
                    { 2, "Jan Brzechwa", new DateTime(2023, 12, 26, 14, 46, 11, 973, DateTimeKind.Local).AddTicks(6834), "12345678", 1, "200", 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wydawnictwo ABC", "Przykładowa Książka 1" },
                    { 3, "Jan Brzechwa", new DateTime(2023, 12, 26, 14, 46, 11, 973, DateTimeKind.Local).AddTicks(6841), "12345678", 1, "200", 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wydawnictwo ABC", "Przykładowa Książka 1" },
                    { 4, "Jan Brzechwa", new DateTime(2023, 12, 26, 14, 46, 11, 973, DateTimeKind.Local).AddTicks(6848), "12345678", 1, "200", 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wydawnictwo ABC", "Przykładowa Książka 1" },
                    { 5, "Jan Brzechwa", new DateTime(2023, 12, 26, 14, 46, 11, 973, DateTimeKind.Local).AddTicks(6855), "12345678", 1, "200", 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wydawnictwo ABC", "Przykładowa Książka 1" },
                    { 6, "Jan Brzechwa", new DateTime(2023, 12, 26, 14, 46, 11, 973, DateTimeKind.Local).AddTicks(6864), "12345678", 1, "200", 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wydawnictwo ABC", "Przykładowa Książka 1" },
                    { 7, "Jan Brzechwa", new DateTime(2023, 12, 26, 14, 46, 11, 973, DateTimeKind.Local).AddTicks(6870), "12345678", 1, "200", 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wydawnictwo ABC", "Przykładowa Książka 1" },
                    { 8, "Jan Brzechwa", new DateTime(2023, 12, 26, 14, 46, 11, 973, DateTimeKind.Local).AddTicks(6876), "12345678", 1, "200", 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wydawnictwo ABC", "Przykładowa Książka 1" }
                });

            migrationBuilder.InsertData(
                table: "contacts",
                columns: new[] { "Id", "birth_date", "Created", "Email", "Name", "OrganizationId", "Phone", "Priority" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 26, 14, 46, 11, 973, DateTimeKind.Local).AddTicks(6885), "adam@wsei.edu.pl", "Adam", 1, "127813268163", 1 },
                    { 2, new DateTime(1999, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 26, 14, 46, 11, 973, DateTimeKind.Local).AddTicks(6887), "ewa@wsei.edu.pl", "Ewa", 3, "293443823478", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_books_LibraryId",
                table: "books",
                column: "LibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_contacts_OrganizationId",
                table: "contacts",
                column: "OrganizationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Libraries");

            migrationBuilder.DropTable(
                name: "organizations");
        }
    }
}
