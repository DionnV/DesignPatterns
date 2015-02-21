using System;
using System.Collections.Generic;
using System.Text;

namespace Design Patterns.Opdracht2
{
	public abstract class FuelTank
	{
		public float Content
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

		public abstract FuelType FuelType
		{
			get;
			set;
		}
	}
}
