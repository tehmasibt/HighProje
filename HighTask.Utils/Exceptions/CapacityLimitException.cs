using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighTask.Utils.Exceptions
{
    public class CapacityLimitException : Exception
    {
        public CapacityLimitException()
        {
            
        }
        public CapacityLimitException(string message) : base(message)
        {

        }
        public CapacityLimitException(string message, Exception innerException) : base(message, innerException)
        {

        }
        
        
    }
}
