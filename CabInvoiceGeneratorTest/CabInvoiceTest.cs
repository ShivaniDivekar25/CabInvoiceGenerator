using CabInvoiceGeneratorProgram;

namespace CabInvoiceGeneratorTest
{
    public class CabInvoiceTest
    {
        CabInvoiceGenerator cabInvoice = new CabInvoiceGenerator();
        [Test]
        public void Given_Distance_And_Time_Return_TotalFare()
        {
            cabInvoice = new CabInvoiceGenerator();
            Ride ride = new Ride(5, 5, RideType.RideTypes.NORMAL);
            double actual = cabInvoice.CalculateFare(ride);
            Assert.AreEqual(actual, 55);
        }
        [Test]
        public void Given_Multiple_Rides_Return_TotalFare()
        {
            Ride[] rides = { new Ride(2, 3, RideType.RideTypes.PRIMIUM), new Ride(5, 2, RideType.RideTypes.NORMAL) };
            InvoiceSummary expected = new InvoiceSummary(88, rides.Length);
            InvoiceSummary actual = cabInvoice.CalculateFare(rides);
            Assert.AreEqual(expected, actual);
        }
    }
}