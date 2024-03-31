using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighTask.Utils.Exceptions
{
    public class NullReferenceException : Exception
    {
        public NullReferenceException()
        {
            
        }
        public NullReferenceException(string message) : base(message)
        {

        }
        public NullReferenceException(string message,Exception innerException) : base(message, innerException)
        {

        }
    }
}
