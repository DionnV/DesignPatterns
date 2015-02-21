using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Opdracht2_3_4
{
	public abstract class CarFactory
	{
        public abstract FuelTank CreateFuelTank();

        public abstract Engine CreateEngine();
	}
}
