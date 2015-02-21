using System;
using System.Collections.Generic;
using System.Text;

namespace Design Patterns.Opdracht2
{
	public abstract class CarFactory
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
