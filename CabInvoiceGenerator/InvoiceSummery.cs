///--------------------------------------------------------------------
///   Class:       InvoiceSummery
///   Description: Cointains method CalculateAverageFare 
///   Author:      Nitikesh Shinde                   Date: 05/05/2020
///--------------------------------------------------------------------

namespace CabInvoiceGenerator
{
    public class InvoiceSummery
    {
        //Getters and Setters
        public int totalNumberOfRides { get; set; }
        public double totalFare { get; set; }
        public double averageFarePerRide { get; set; }


        /// <CalulateAverageFare>
        /// Calculating averageFare among totalNumberof rides.
        /// and Accessing averageFarePer Ride with help of class InvoiceSummery's object
        /// </CalulateAverageFare>
        public void CalulateAverageFare()
        {
            averageFarePerRide = totalFare / totalNumberOfRides;
        }
    }
}
