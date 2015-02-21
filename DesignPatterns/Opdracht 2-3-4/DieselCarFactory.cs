using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Opdracht2_3_4
{
	public class DieselCarFactory : CarFactory
	{
		public FuelTank CreateFuelTank()
		{
			return new DieselTank();
		}

		public Engine CreateEngine()
		{
			return new DieselEngine();
		}
	}
}
