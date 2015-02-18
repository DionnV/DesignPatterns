using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Opdracht_1.CustomException;

namespace DesignPatterns.Opdracht_1
{
    public class Flap : ICalculatable
    {
        public void Calculate() 
        {
            Random rng = new Random();
            if (rng.NextDouble() < 0.0005) throw new FlapException("Flap crash");
        }
    }
}
