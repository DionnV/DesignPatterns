using System;
using System.Collections.Generic;
using System.Text;

namespace Design Patterns.Opdracht2
{
	public class GasCarFactory : CarFactory
	{
		public FuelTank CreateFuelTank()
		{
			throw new NotImplementedException();
		}

		public Engine CreateEngine()
		{
			throw new NotImplementedException();
		}
	}
}
