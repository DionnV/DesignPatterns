using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Opdracht_1
{
    public class Recorder
    {
        public void Simulate() 
        {
            //Simuleer vlucht eenmaal
            Airplane airplane = new Airplane();
            airplane.Flight();
        }
    }
}
