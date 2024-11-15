using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency.Missions
{
    internal class CombatMission<T> : Missions<T>
    {
        public CombatMission(string location, int reward) : base(location, reward)
        {
        }
    }
}
