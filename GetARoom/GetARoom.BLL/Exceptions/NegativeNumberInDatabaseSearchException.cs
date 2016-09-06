using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.BLL.Exceptions
{
    public class NegativeNumberInDatabaseSearchException : Exception
    {

        public NegativeNumberInDatabaseSearchException() : base()
        {

        }
        public NegativeNumberInDatabaseSearchException(string message) : base(message)
        {

        }
    }
}
