using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneratorProgram
{
    public class CabInvoiceGenerator
    {
        //Created method to calculate fare for ecah ride
        public double CalculateFare(Ride ride)
        {
            double totalFare = 0;
            if (ride.distance <= 0)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionTypes.INVALID_DISTANCE, "Distance should be above zero");
            }
            else if (ride.time <= 0)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionTypes.INVALID_TIME, "Time should be above zero");
            }
            else
            {
                totalFare = ride.distance * ride.COST_PER_KM + ride.time * ride.COST_PER_MINUTE;
            }
            return Math.Max(totalFare, ride.MINIMUM_FARE);
        }
        //Creted method to calculate fare for no of rides
        public InvoiceSummary CalculateFare(Ride[] rides)
        {
            double totalFare = 0;
            foreach (Ride ride in rides)
            {
                totalFare = totalFare + CalculateFare(ride);
            }
            return new InvoiceSummary(totalFare, rides.Length);
        }
    }
}
