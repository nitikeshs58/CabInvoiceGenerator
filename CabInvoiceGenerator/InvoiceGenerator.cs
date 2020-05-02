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
        // Declared and Initialised Variables
        readonly private double costPerKiloMeter = 10.0;
        readonly private double costPerMinute = 1.0;
        readonly private double minimumFare = 5.0;

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
        public double CalculateCabFare(double runningDistance, double runningTime)
        {
            double totalFare = (runningDistance * costPerKiloMeter) + (runningTime * costPerMinute);
            if (totalFare < minimumFare)
            {
                return minimumFare;
            }
            return totalFare;
        }

        /// <CalculateCabFare>
        /// Method to calculated fare of multiple rides
        /// </CalculateCabFare>
        /// <param name="rides"></param>
        /// <returns></returns>
        public double CalculateCabFare(Ride[] rides)
        {
            double totalFare = 0;
            foreach(Ride ride in rides)
            {
                totalFare += CalculateCabFare(ride.rideDistance,ride.rideTime);
            }
            if (totalFare < minimumFare)
            {
                return minimumFare;
            }
            return totalFare;
        }
    }
}