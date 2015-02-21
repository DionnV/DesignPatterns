using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Opdracht2_3_4
{
	public abstract class Engine
	{
		public void Start()
		{
			//CAR STARTED
		}

		public void Stop()
		{
			//CAR STOPPED
		}

        public Fluctuation Fluctuation
        {
            get;
            set;
        }

        public int Revs
        {
            get;
            set;
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
