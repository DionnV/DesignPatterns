using System;
using System.Collections.Generic;
using System.Text;

namespace Design Patterns.Opdracht2
{
	public class DieselEngine : Engine
	{
		public override float FuelUsagePerSecond
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public override FuelType FuelType
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}
	}
}
