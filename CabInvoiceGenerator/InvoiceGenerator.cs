///--------------------------------------------------------------------
///   Class:       InvoiceGenerator
///   Description: Constains Parameterised Constructor and Method named CalculateCabFare
///                 which calculates total fare of a journey.
///   Author:      Nitikesh Shinde                   Date: 02/05/2020
///--------------------------------------------------------------------

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        // Declared and Initialised Variables of normal rides
        readonly private double normaolCostPerKiloMeter = 10.0;
        readonly private double normalCostPerMinute = 1.0;
        readonly private double normalMinimumFare = 5.0;
        // Declared and Initialised Variables of Premimum rides
        readonly private double premiusCostPerKiloMeter = 15.0;
        readonly private double premimunCostPerMinute = 2.0;
        readonly private double premimunMinimumFare = 20.0;

        /// <InvoiceGenerator>
        /// default Constructor
        /// </InvoiceGenerator>
        public InvoiceGenerator()
        {
        }

        /// <CalculateCabFare>
        /// Calculating Total Fare of a journey.
        /// </CalculateCabFare>
        /// <minimumFare></returns>
        /// <totalFare></returns>
        public double CalculateCabFare(string rideType, double runningDistance, double runningTime)
        {
            // Calculation for normalFare
            if (rideType == "normal")
            {
                double totalFare = (runningDistance * normaolCostPerKiloMeter) + (runningTime * normalCostPerMinute);
                if (totalFare < normalMinimumFare)
                {
                    return normalMinimumFare;
                }
                return totalFare;
            }

            // Calculation for premimunFare
            if (rideType=="premium")
            {
                double totalFare = (runningDistance * premiusCostPerKiloMeter) + (runningTime * premimunCostPerMinute);
                if (totalFare > premimunMinimumFare)
                {
                    return totalFare;
                }               
            }
            return premimunMinimumFare;
        }
            /// <CalculateCabFare>
            /// Method to calculated fare of multiple rides
            /// </CalculateCabFare>
            /// <param name="rides"></param>
            /// <returns></returns>
            public InvoiceSummery CalculateCabFare(Ride[] rides)
        {
                int totalNumberOfRides=0;
                double totalFare=0;
            foreach (Ride ride in rides)
            {
                totalFare += CalculateCabFare(ride.rideType,ride.rideDistance,ride.rideTime);
                totalNumberOfRides+=1;
            }
            // Object of InvoiceSummery and accessing data from class
            InvoiceSummery invoiceSummery = new InvoiceSummery();
            invoiceSummery.totalNumberOfRides = totalNumberOfRides;
            invoiceSummery.totalFare = totalFare;
            invoiceSummery.CalulateAverageFare();
            return invoiceSummery;
        }
    }
}