using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneratorProgram
{
    public class InvoiceSummary
    {
        public double totalFare;
        public int numOfRides;
        public double average;

        //Created constructor
        public InvoiceSummary(double totalFare, int numOfRides)
        {
            this.totalFare = totalFare;
            this.numOfRides = numOfRides;
            this.average = totalFare / numOfRides;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is InvoiceSummary))
            {
                return false;
            }
            InvoiceSummary invoiceSummary = (InvoiceSummary)obj;
            return numOfRides == invoiceSummary.numOfRides && totalFare == invoiceSummary.totalFare && average == invoiceSummary.average;
        }
    }
}
