using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CabInvoiceGeneratorProgram.RideType;

namespace CabInvoiceGeneratorProgram
{
    public class Ride
    {
        public double distance;
        public int time;
        public readonly int MINIMUM_FARE;
        public readonly int COST_PER_MINUTE;
        public readonly int COST_PER_KM;
        public RideTypes rideTypes;

        //Cretaed Ride method with parameter
        public Ride(double distance, int time, RideType.RideTypes rideTypes)
        {
            this.distance = distance;
            this.time = time;
            this.rideTypes = rideTypes;

            if (rideTypes == RideType.RideTypes.NORMAL)
            {
                MINIMUM_FARE = 5;
                COST_PER_MINUTE = 1;
                COST_PER_KM = 10;
            }
            else
            {
                MINIMUM_FARE = 20;
                COST_PER_MINUTE = 2;
                COST_PER_KM = 15;
            }
        }

    }
}
