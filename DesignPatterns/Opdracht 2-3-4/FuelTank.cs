using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Opdracht2_3_4
{
	public abstract class FuelTank
	{
        private float _Content;
        public float Content
        {
            get
            {
                return _Content;
            }
            set
            {
                if (value < 0) _Content = 0;
                else _Content = value;
            }
        }

		public abstract FuelType FuelType
		{
			get;
			set;
		}
	}
}
