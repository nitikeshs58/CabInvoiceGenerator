///--------------------------------------------------------------------
///   Class:       Tests
///   Description: Cointains test method to check Cab Invoice. 
///   Author:      Nitikesh Shinde                   Date: 02/05/2020
///--------------------------------------------------------------------

using NUnit.Framework;
using CabInvoiceGenerator;

namespace CabInvoiceTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <test 1>
        /// Creating an object of InvoiceGenerator
        /// sending two parameters as cabRunningDistance and canRunningTime
        /// </test 1>
        [Test]
        public void GivenDistanceAndTimeToInvoiceGeneratorShouldReturnTotalFare()
        {
            double cabRunningDistance = 5.0;
            double cabRunningTime = 2.0;
            InvoiceGenerator invoice = new InvoiceGenerator();
            Assert.AreEqual(52, invoice.CalculateCabFare(cabRunningDistance, cabRunningTime));
        }

        /// <test 2>
        /// Creating an object of InvoiceGenerator
        /// sending two parameters as cabRunningDistance and canRunningTime
        /// </test 2>
        [Test]
        public void GivenDistanceAndTimeOfMultiRidesToInvoiceGeneratorShouldReturnTotalFare()
        {
            Ride[] rides=
                {
                new Ride(2.0,1.0),
                new Ride(2.5,1.5)
                };
            InvoiceGenerator invoice = new InvoiceGenerator();
            Assert.AreEqual(47.5, invoice.CalculateCabFare(rides));
        }
    }
}