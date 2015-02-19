using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Opdracht_2_3_4
{
    public class Car
    {
        public MotorBase Motor { get; set; }

        public Car(MotorBase motor)
        {
            Motor = motor;
        }
    }
}
