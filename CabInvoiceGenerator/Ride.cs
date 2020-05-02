///--------------------------------------------------------------------
///   Class:       Ride
///   Description: Contains parameterised constructor. 
///   Author:      Nitikesh Shinde                   Date: 02/05/2020
///--------------------------------------------------------------------

namespace CabInvoiceGenerator
{
    public class Ride
    {
        readonly public double rideDistance;
        readonly public double rideTime;
        public Ride(double runningDistance, double runningTime)
        {
            this.rideDistance = runningDistance;
            this.rideTime = runningTime;
        }
    }
}