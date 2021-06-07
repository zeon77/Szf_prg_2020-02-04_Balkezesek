using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    class Játékos
    {
        public string Név { get; set; }
        public DateTime ElsőMeccs { get; set; }
        public DateTime UtolsóMeccs { get; set; }
        public double SúlyFont { get; set; }
        public double MagasságInch { get; set; }
        
        public Játékos(string sor)
        {

        }
    }
}
