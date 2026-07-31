using System;
using System.Collections.Generic;
using Teretana.DataLayer;

namespace Teretana.BusinessLayer
{
    public class TreningService
    {
        private TreningRepository treningRepository = new TreningRepository();

        public List<Trening> VratiSveTreninge()
        {
            return treningRepository.VratiSveTreninge();
        }

        public string DodajTrening(Trening trening)
        {
            if (string.IsNullOrWhiteSpace(trening.Naziv))
                return "Naziv treninga je obavezan.";

            if (string.IsNullOrWhiteSpace(trening.Trener))
                return "Ime trenera je obavezno.";

            if (trening.Trajanje <= 0)
                return "Trajanje mora biti veće od 0.";

            if (trening.MaxBrojUcesnika <= 0)
                return "Maksimalan broj učesnika mora biti veći od 0.";

            if (trening.DatumTermina < DateTime.Now)
                return "Datum termina ne može biti u prošlosti.";

            treningRepository.DodajTrening(trening);
            return null;
        }

        public string IzmeniTrening(Trening trening)
        {
            if (string.IsNullOrWhiteSpace(trening.Naziv))
                return "Naziv treninga je obavezan.";

            treningRepository.IzmeniTrening(trening);
            return null;
        }

        public void ObrisiTrening(int idTreninga)
        {
            treningRepository.ObrisiTrening(idTreninga);
        }

        public bool JeTreningPun(int idTreninga, int maxBrojUcesnika)
        {
            int trenutnoPrijavljenih = treningRepository.BrojPrijavljenih(idTreninga);
            return trenutnoPrijavljenih >= maxBrojUcesnika;
        }
    }
}
