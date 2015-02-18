using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Opdracht_1.CustomException;

namespace DesignPatterns.Opdracht_1
{
    public class Pilot : ICalculatable
    {
        public void Calculate() 
        {
            Random rng = new Random();
            if (rng.NextDouble() < 0.005) throw new PilotException("Pilot crash");
        }
    }
}
