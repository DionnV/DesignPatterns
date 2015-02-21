using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Opdracht2_3_4
{
	public class GasTank : FuelTank
	{
		public override FuelType FuelType
		{
			get
			{
                return FuelType.Gas;
			}
		}
	}
}
