using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teretana.DataLayer;

namespace Teretana.BusinessLayer
{
    public class ClanService
    {
        private ClanRepository clanRepository = new ClanRepository();

        // Registracija - sa validacijom
        public string Registruj(Clan clan)
        {
            if (string.IsNullOrWhiteSpace(clan.Ime) || string.IsNullOrWhiteSpace(clan.Prezime))
                return "Ime i prezime su obavezni.";

            if (string.IsNullOrWhiteSpace(clan.Email) || !clan.Email.Contains("@"))
                return "Unesite ispravnu email adresu.";

            if (string.IsNullOrWhiteSpace(clan.KorisnickoIme) || clan.KorisnickoIme.Length < 3)
                return "Korisničko ime mora imati bar 3 karaktera.";

            if (string.IsNullOrWhiteSpace(clan.Lozinka) || clan.Lozinka.Length < 4)
                return "Lozinka mora imati bar 4 karaktera.";

            if (clanRepository.KorisnickoImePostoji(clan.KorisnickoIme))
                return "Korisničko ime je već zauzeto.";

            if (string.IsNullOrWhiteSpace(clan.TipClanarine))
                clan.TipClanarine = "Osnovna";

            clanRepository.DodajClana(clan);
            return null; // null = uspešno, bez greške
        }

        // Login - vraća člana ako su podaci ispravni, null ako nisu
        public Clan Prijava(string korisnickoIme, string lozinka)
        {
            if (string.IsNullOrWhiteSpace(korisnickoIme) || string.IsNullOrWhiteSpace(lozinka))
                return null;

            return clanRepository.Login(korisnickoIme, lozinka);
        }
    }
}
