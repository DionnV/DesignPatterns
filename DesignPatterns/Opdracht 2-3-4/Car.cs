using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatterns.Opdracht2_3_4
{
	public class Car
	{
        public Engine Engine
        {
            get;
            set;
        }

        public string Brand
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public FuelTank FuelTank
        {
            get;
            set;
        }

        public void Drive()
        {
            Engine.Start();
            Engine.Revs = 1000;
            while(FuelTank.Content > 0)
            {
                FuelTank.Content -= Engine.FuelUsagePerSecond;
                Thread.Sleep(999);
            }
            Engine.Stop();
        }
	}
}
