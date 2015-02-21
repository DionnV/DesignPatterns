using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Opdracht2_3_4
{
	public class GasCarFactory : CarFactory
	{
		public FuelTank CreateFuelTank()
		{
            return new GasTank();
		}

		public Engine CreateEngine()
		{
            return new GasEngine();
		}
	}
}
