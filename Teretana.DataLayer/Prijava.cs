using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teretana.DataLayer
{
    public class Prijava
    {
        public int IdPrijave { get; set; }
        public int IdClana { get; set; }
        public int IdTreninga { get; set; }
        public DateTime DatumPrijave { get; set; }
        public string Status { get; set; }
    }
}
