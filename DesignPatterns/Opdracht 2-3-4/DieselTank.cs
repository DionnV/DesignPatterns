using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Opdracht2_3_4
{
	public class DieselTank : FuelTank
	{
		public override FuelType FuelType
		{
			get
			{
				return FuelType.Diesel;
			}
		}
	}
}
