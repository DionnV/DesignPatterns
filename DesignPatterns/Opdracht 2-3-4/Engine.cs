using System;
using System.Collections.Generic;
using System.Text;

namespace Design Patterns.Opdracht2
{
	public abstract class Engine
	{
		public void Start()
		{
			throw new NotImplementedException();
		}

		public void Stop()
		{
			throw new NotImplementedException();
		}

		public Fluctuation Fluctuation
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

		public int Revs
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

		public abstract float FuelUsagePerSecond
		{
			get;
		}

		public abstract FuelType FuelType
		{
			get;
			set;
		}
	}
}
