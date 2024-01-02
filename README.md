# Library Management System ASP.NET Core Project Documentation

## Author: Krupa Remigiusz

### Introduction

This project develops a comprehensive library management system using ASP.NET technology, empowering users to manage books, libraries, and lending processes efficiently. The system allows for both administrative and regular user logins, providing functionalities such as adding, editing, and deleting book records, managing library details, and handling book borrowings.

**Note:** The application is pre-loaded with sample data for demonstration purposes.

### Technologies Utilized

- **ASP.NET Core 7.0**
- **Database:** SQLite
- **Entity Framework Core:** For database operations
- **LINQ:** For database queries
- **Identity Framework:** For user authentication and role management

### Requirements

- **.NET 7.0:** Ensure the .NET environment version 7.0 is installed. Download it from the [.NET official site](https://dotnet.microsoft.com/download).
- **Entity Framework:** The application leverages Entity Framework, so its installation is necessary.

### NuGet Packages

- **Microsoft.EntityFrameworkCore** version 7.0.13
- **Microsoft.EntityFrameworkCore.Design** version 7.0.13
- **Microsoft.EntityFrameworkCore.Sqlite** version 7.0.13
- **Microsoft.AspNetCore.Identity.EntityFrameworkCore** version 6.0.25

### User Accounts

- **Administrator**
  - Login: `test@test.pl`
  - Password: `abc1234!`
  - Role: `ADMIN`
- **Regular User**
  - Login: `jan@przyklad.pl`
  - Password: `hasloJan123!`
  - Role: `USER`
- **Regular User**
  - Login: `anna@przyklad.pl`
  - Password: `hasloAnna123!`
  - Role: `USER`

### Application Launch Process

1. **Clone the repository:** Clone the GitHub repository.
2. **Install dependencies:** Use `dotnet restore` in the project directory to install necessary dependencies.
3. **Database migration:** Execute `dotnet ef database update` to apply migrations to the SQLite database.
4. **Start the application:** Run `dotnet run` in the project directory to launch the application.

### Functionalities Overview

- **Library Management:** Adding, editing, and deleting library details.
- **Books Handling:** Ability to add, edit, and remove books from the database.
- **Book Lending:** Facilitating the borrowing and return process of books.
- **User Accounts Management:** Administration of user accounts, including assigning roles and permissions.

### Security and Optimization

- **Identity Framework Protections:** Secures user data and manages access across different sections of the application.
- **Data Validation:** Ensures the integrity and correctness of data entered into the system.

### Detailed Functionalities

- **User Account Management:** Users can log in and manage their accounts.
- **Library Collection Management:** Administrators can oversee the entire collection, adding new books as needed.
- **Book Borrowing:** Users can borrow available books and manage their lending history.
