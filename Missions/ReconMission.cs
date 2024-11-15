using SuperheroAgency.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency.Missions
{
    internal class ReconMission<T> : Missions<T> where T : IFly
    {
        public ReconMission(string location, int reward) : base(location, reward)
        {
        }
    }
}
