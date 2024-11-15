using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency.Missions
{
    internal class RescueMission<T> : Missions<T>
    {
        public RescueMission(string location, int reward) : base(location, reward)
        {
        }
    }
}
