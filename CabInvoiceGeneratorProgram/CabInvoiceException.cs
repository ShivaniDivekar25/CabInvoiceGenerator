using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneratorProgram
{
    public class CabInvoiceException : Exception
    {
        public ExceptionTypes type;

        //Creted method for custom exception
        public CabInvoiceException(ExceptionTypes type, string message) : base(message)
        {
            this.type = type;
        }
        public enum ExceptionTypes
        {
            INVALID_DISTANCE, INVALID_TIME, NULL_RIDES, INVALIDE_USER_ID, INVALIDE_RIDETYPE
        }
    }
}
