using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Opdracht_2_3_4
{
    public class MyFirstMotor : MotorBase
    {
        public override float CalculateFuelUsageForCurrentTick()
        {
            //Simuleer brandsstofverbruik voor mijn eerste motor
            return (float)CurrentRotationsPerMinute / 1000 + .2f;
        }

        public override float CalculateRPMForCurrentTick()
        {
            Random rng = new Random();
            //Simuleer fluctuatie voor mijn eerste motor
            if (!IsAccelerating)
                return (rng.NextDouble() < 0.5 ? -1 : 1) * 12f + (StationaryRotationsPerMinute - CurrentRotationsPerMinute) / 2;
            //Simuleer versnelling voor mijn eerste motor
            else
                return CurrentRotationsPerMinute * .3f;
        }

        public override float StationaryRotationsPerMinute
        {
            get
            {
                return 1100;
            }
        }
    }
}
