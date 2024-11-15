using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    public abstract class Superhero
    {
        public Superhero(string alias, string secretIdentity, int age, Alignment alignment)
        {
            Alias = alias;
            SecretIdentity = secretIdentity;
            Age = age;
            Alignment = alignment;
        }

        public string Alias { get; }
        public string SecretIdentity { get; }
        public int Age { get; }
        public Alignment Alignment { get; }

    }
}
