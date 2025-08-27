# MT\_bank

**A simple C# WinForms banking system with MySQL**

This project demonstrates a basic user login system and balance display for educational purposes.

---

## Features

* User login with username and password.
* Display user balance on the main form.

---

## Requirements

* Windows with .NET Framework (WinForms)
* MySQL or MariaDB
* MySQL Connector/NET for C#

---

## Database Setup

1. Create a new database:

```sql
CREATE DATABASE rakimakifaki;
```

2. Import the users table from the dump:

```bash
mysql -u root -p rakimakifaki < users.sql
```

3. Example table structure:

```sql
CREATE TABLE users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    login VARCHAR(50) NOT NULL,
    password_hash VARCHAR(255) NOT NULL,
    money DECIMAL(18,2) DEFAULT 0
);
```

---

2. Use this connection string in `DB.cs` to connect to the database.

---

## Running the Project

1. Open `MT_bank.sln` in Visual Studio.
2. Install the NuGet package **MySql.Data**.
4. Run the project (`F5`) and use a login from the SQL dump for testing.

