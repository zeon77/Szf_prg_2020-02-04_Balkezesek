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

        public double MagasságCm { get => MagasságInch * 2.54; }

        public Játékos(string sor)
        {
            string[] s = sor.Split(';');
            Név = s[0];
            ElsőMeccs = DateTime.Parse(s[1]);
            UtolsóMeccs = DateTime.Parse(s[2]);
            SúlyFont = double.Parse(s[3]);
            MagasságInch = double.Parse(s[4]);
        }
    }
}
