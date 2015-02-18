using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Opdracht_1.CustomException
{
    public class CrashException : Exception
    {
        public CrashException()
        {
        }

        public CrashException(string message)
            : base(message)
        {
        }

        public CrashException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
