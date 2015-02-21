using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Opdracht2_3_4
{
	public class PetrolEngine : Engine
	{
		public override float FuelUsagePerSecond
		{
			get
			{
                return 0.002f * Revs;
			}
		}

		public override FuelType FuelType
		{
			get
			{
                return FuelType.Petrol;
			}
		}
	}
}
