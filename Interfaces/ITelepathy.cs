using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency.Interfaces
{
    internal interface ITelepathy
    {
        public int PowerLevel { get; set; }

        public void ReadMind(string alias)
        {
            Console.WriteLine($"{alias} is reading your thoughts!");
        }
    }
}
