using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Opdracht_1.CustomException
{
    public class PilotException : Exception
    {
        public PilotException()
        {
        }

        public PilotException(string message)
            : base(message)
        {
        }

        public PilotException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
