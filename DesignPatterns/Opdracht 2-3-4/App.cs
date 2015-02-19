using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DesignPatterns.Opdracht_2_3_4
{
    public class App
    {
        public static void Main(String[] args)
        {
            Car car = new Car(new MyFirstMotor());
            car.Motor.Start();
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine("RPM: " + car.Motor.CurrentRotationsPerMinute);
                Console.WriteLine("FuelUsage: " + car.Motor.TotalFuelUsage);
                car.Motor.IsAccelerating = i > 3 && i < 10;
                Thread.Sleep(500);
            }
        }
    }
}
