using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitter.Exception
{
    internal class ExceptionBase
    {
        private string message;

        public ExceptionBase(string message)
        {
            this.message = message;
        }
    }
}
