using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Opdracht2_3_4
{
	public class PetrolCarFactory : CarFactory
	{
		public FuelTank CreateFuelTank()
		{
            return new PetrolTank();
		}

		public Engine CreateEngine()
		{
            return new PetrolEngine();
		}
	}
}
