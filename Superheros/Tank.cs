using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperheroAgency.Interfaces;

namespace SuperheroAgency.Superheros
{
    internal class Tank : Superhero, IFly, IStrength
    {
        public Tank(string alias, string secretIdentity, int age, Alignment alignment) : base(alias, secretIdentity, age, alignment)
        {
        }

        public double FlightSpeed { get; set; }
        public double MaxHeight { get; set; }
        public int StrengthLevel { get; set; }
    }
}
