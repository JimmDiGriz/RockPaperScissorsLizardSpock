using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class LessOrEqualsToZeroException : Exception
    {
        public LessOrEqualsToZeroException() : this("Number of variant is less or equals to zero.") { }

        public LessOrEqualsToZeroException(string message) : base(message) { }

        public LessOrEqualsToZeroException(string message, Exception inner) : base(message, inner) { }
    }
}
