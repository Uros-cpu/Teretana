using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teretana.DataLayer
{
    public class Trening
    {
        public int IdTreninga { get; set; }
        public string Naziv { get; set; }
        public string Trener { get; set; }
        public string TipTreninga { get; set; }
        public int Trajanje { get; set; }
        public int MaxBrojUcesnika { get; set; }
        public DateTime DatumTermina { get; set; }
    }
}
