using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency.Missions
{
    public abstract class Missions<T>
    {
        public string location { get; }
        public int reward { get; }

        public List<T> HeroesDeployed { get; } = new List<T>();

        public Missions(string location, int reward)
        {
            this.location = location;
            this.reward = reward;
        }
    }
}
