using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Opdracht2_3_4
{
	public class GasEngine : Engine
	{
		public override float FuelUsagePerSecond
		{
			get
			{
                return 0.0002f * Revs;
			}
		}

		public override FuelType FuelType
		{
			get
			{
                return FuelType.Gas;
			}
		}
	}
}
