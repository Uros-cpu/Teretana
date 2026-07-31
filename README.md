U ovom seminarskom radu opisana je aplikacija koja predstavlja sistem za 
upravljanje članstvom i treninzima u teretani. Aplikacija omogućava 
registraciju i prijavu članova, pregled ponuđenih treninga, prijavljivanje i 
otkazivanje prijave na trening, kao i administraciju treninga (dodavanje, 
izmenu i brisanje) od strane administratora teretane. 
Razvojno okruženje korišćeno za izradu aplikacije je Visual Studio 2026, a 
aplikacija je u potpunosti napisana u programskom jeziku C#, korišćenjem 
Windows Forms tehnologije za korisnički interfejs. 
Aplikacija koristi troslojnu arhitekturu i sastoji se od sledeća tri projekta 
(sloja) unutar jednog solution-a: 
● Teretana.DataLayer — sloj za komunikaciju sa bazom podataka 
● Teretana.BusinessLayer — sloj poslovne logike 
● Teretana.Presentation — prezentacioni sloj (Windows Forms)
