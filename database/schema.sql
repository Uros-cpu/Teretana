-- =====================================================================
-- TeretanaDB – SQL Server schema
-- Reconstructed from the queries in Teretana.DataLayer
-- (ClanRepository, TreningRepository, PrijavaRepository).
-- Run this first, then SQLQuery1.sql for sample trainings.
-- =====================================================================

CREATE TABLE Clan (
    IdClana        INT IDENTITY(1,1) PRIMARY KEY,
    Ime            NVARCHAR(50)  NOT NULL,
    Prezime        NVARCHAR(50)  NOT NULL,
    Email          NVARCHAR(100) NOT NULL,
    Telefon        NVARCHAR(30)  NULL,
    KorisnickoIme  NVARCHAR(50)  NOT NULL UNIQUE,
    Lozinka        NVARCHAR(100) NOT NULL,
    TipClanarine   NVARCHAR(20)  NOT NULL DEFAULT 'Osnovna'
);

CREATE TABLE Trening (
    IdTreninga      INT IDENTITY(1,1) PRIMARY KEY,
    Naziv           NVARCHAR(100) NOT NULL,
    Trener          NVARCHAR(100) NOT NULL,
    TipTreninga     NVARCHAR(50)  NOT NULL,
    Trajanje        INT           NOT NULL,   -- minutes
    MaxBrojUcesnika INT           NOT NULL,
    DatumTermina    DATETIME      NOT NULL
);

CREATE TABLE Prijava (
    IdPrijave    INT IDENTITY(1,1) PRIMARY KEY,
    IdClana      INT          NOT NULL REFERENCES Clan(IdClana),
    IdTreninga   INT          NOT NULL REFERENCES Trening(IdTreninga),
    DatumPrijave DATETIME     NOT NULL DEFAULT GETDATE(),
    Status       NVARCHAR(20) NOT NULL DEFAULT 'prijavljen'   -- 'prijavljen' / 'otkazano'
);
