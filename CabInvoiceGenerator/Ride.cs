///--------------------------------------------------------------------
///   Class:       Ride
///   Description: Contains parameterised constructor. 
///   Author:      Nitikesh Shinde                   Date: 05/05/2020
///--------------------------------------------------------------------

namespace CabInvoiceGenerator
{
    public class Ride
    {
        // Declared Variables
        readonly public double rideDistance;
        readonly public double rideTime;
        readonly public string rideType;

        /// <summary>
        /// Parameterised Constructor
        /// </summary>
        /// <param name="rideType"></param>
        /// <param name="runningDistance"></param>
        /// <param name="runningTime"></param>
        public Ride(string rideType,double runningDistance, double runningTime)
        {
            this.rideType = rideType;
            this.rideDistance = runningDistance;
            this.rideTime = runningTime;
        }
    }
}