using SuperheroAgency.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency.Missions
{
    internal class HackingMission<T> : Missions<T> where T : ITech
    {
        public HackingMission(string location, int reward) : base(location, reward)
        {
        }
    }
}
