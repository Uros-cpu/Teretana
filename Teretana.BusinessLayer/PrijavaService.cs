using System.Collections.Generic;
using Teretana.DataLayer;

namespace Teretana.BusinessLayer
{
    public class PrijavaService
    {
        private PrijavaRepository prijavaRepository = new PrijavaRepository();
        private TreningRepository treningRepository = new TreningRepository();

        // Prijava na trening - sa proverama
        public string PrijaviSeNaTrening(int idClana, int idTreninga)
        {
            Trening trening = treningRepository.VratiTreningPoId(idTreninga);
            if (trening == null)
                return "Trening ne postoji.";

            if (prijavaRepository.VecPrijavljen(idClana, idTreninga))
                return "Već ste prijavljeni na ovaj trening.";

            int brojPrijavljenih = treningRepository.BrojPrijavljenih(idTreninga);
            if (brojPrijavljenih >= trening.MaxBrojUcesnika)
                return "Trening je popunjen.";

            Prijava prijava = new Prijava
            {
                IdClana = idClana,
                IdTreninga = idTreninga
            };

            prijavaRepository.DodajPrijavu(prijava);
            return null; // uspešno
        }

        public void OtkaziPrijavu(int idPrijave)
        {
            prijavaRepository.OtkaziPrijavu(idPrijave);
        }

        public List<PrijavaSaTreningom> VratiMojePrijave(int idClana)
        {
            return prijavaRepository.VratiPrijaveClana(idClana);
        }
    }
}
