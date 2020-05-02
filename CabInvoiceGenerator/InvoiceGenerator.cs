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
        readonly private double distance;
        readonly private double time;
        readonly private double costPerKiloMeter = 10.0;
        readonly private double costPerMinute = 1.0;
        readonly private double minimumFare = 5.0;

        /// <InvoiceGenerator>
        /// Parameterised Constructor
        /// </InvoiceGenerator>
        /// <param name="runningDistance"></param>
        /// <param name="runningTime"></param>
        public InvoiceGenerator(double runningDistance, double runningTime)
        {
            this.distance = runningDistance;
            this.time = runningTime;
        }

        /// <CalculateCabFare>
        /// Calculating Total Fare of a journey.
        /// </CalculateCabFare>
        /// <minimumFare></returns>
        /// <totalFare></returns>
        public double CalculateCabFare()
        {
            double totalFare = (distance * costPerKiloMeter) + (time * costPerMinute);
            if (totalFare < minimumFare)
            {
                return minimumFare;
            }
            return totalFare;
        }
    }
}