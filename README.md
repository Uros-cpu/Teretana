# Teretana – Gym Membership & Training App

Desktop application for managing gym memberships and training sessions, written in **C# / Windows Forms** with a **three-layer architecture** and a **SQL Server** database.

University project for the course *Vizuelno programiranje* (Visual Programming), Faculty of Technical Sciences Čačak.

> 🇷🇸 Kratak opis na srpskom nalazi se [na dnu stranice](#-opis-na-srpskom).

## Features

**Members**
- Registration with validation (required fields, email format, minimum username and password length, unique username)
- Membership type: Osnovna (Basic), Premium or VIP
- Login

**Trainings**
- Browse all scheduled trainings: name, trainer, type, duration, capacity, date and time
- Sign up for a training. The app checks that the member isn't already signed up and that the session isn't full.
- "My trainings" view with the option to cancel. A cancellation keeps the record with status `otkazano` (cancelled), so history is preserved.

**Admin**
- Password-protected admin panel
- Add, edit and delete trainings, with validation (no dates in the past, positive duration and capacity)

## Architecture

The solution is split into three projects, each with one responsibility:

```
Teretana.slnx
├── Teretana.Presentation     # Windows Forms UI
│   ├── FormPrijava           # login (entry point)
│   ├── FormRegistracija      # member registration
│   ├── FormPregledTreninga   # training list + sign up
│   ├── FormMojiTreninzi      # member's sign-ups + cancel
│   └── FormAdminTreninzi     # admin CRUD for trainings
│
├── Teretana.BusinessLayer    # business rules and validation
│   ├── ClanService           # registration and login rules
│   ├── TreningService        # training validation, capacity check
│   └── PrijavaService        # sign-up rules (duplicate / full session)
│
└── Teretana.DataLayer        # data access (ADO.NET)
    ├── Clan, Trening, Prijava            # entity classes
    ├── ClanRepository, TreningRepository, PrijavaRepository
    └── ConnectionHelper                  # SQL Server connection
```

The UI only talks to the services, and only the repositories talk to the database. All SQL queries are **parameterized**, which protects against SQL injection.

## Tech stack

- C#, .NET Framework 4.7.2
- Windows Forms
- ADO.NET (`System.Data.SqlClient`)
- SQL Server LocalDB
- Visual Studio

## Getting started

1. Clone the repository and open `Teretana.slnx` in Visual Studio.
2. Create a database named `TeretanaDB` on `(localdb)\ProjectModels`. You can do it from SQL Server Object Explorer, or change the connection string in `Teretana.DataLayer/ConnectionHelper.cs`.
3. Run `database/schema.sql` to create the tables, then `SQLQuery1.sql` for sample trainings.
4. Set **Teretana.Presentation** as the startup project and run (F5).
5. Register a member, or open the admin panel with the demo password `admin123`.

## Possible improvements

- Store passwords as salted hashes (for example PBKDF2 or BCrypt) instead of plain text
- Keep admins in the database with a role, instead of using a hardcoded admin password
- Move the connection string to `App.config`

## Author

**Uroš Pešić** – student at the Faculty of Technical Sciences Čačak

---

## 🇷🇸 Opis na srpskom

Aplikacija je sistem za upravljanje članstvom i treninzima u teretani. Omogućava registraciju i prijavu članova, pregled ponuđenih treninga, prijavljivanje na trening i otkazivanje prijave, kao i administraciju treninga (dodavanje, izmenu i brisanje) od strane administratora.

Napisana je u programskom jeziku C#, u Windows Forms tehnologiji, u razvojnom okruženju Visual Studio. Koristi troslojnu arhitekturu sa tri projekta unutar jednog solution-a:

- **Teretana.DataLayer** – sloj za komunikaciju sa bazom podataka
- **Teretana.BusinessLayer** – sloj poslovne logike
- **Teretana.Presentation** – prezentacioni sloj (Windows Forms)
