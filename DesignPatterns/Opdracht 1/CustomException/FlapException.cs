using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Opdracht_1.CustomException
{
    public class FlapException : Exception
    {
        public FlapException()
        {
        }

        public FlapException(string message)
            : base(message)
        {
        }

        public FlapException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
