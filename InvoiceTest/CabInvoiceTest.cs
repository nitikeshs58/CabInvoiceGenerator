
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

        /// <summary>
        /// Creating an object of InvoiceGenerator
        /// sending two parameters as cabRunningDistance and canRunningTime
        /// </summary>
        [Test]
        public void GivenDistanceAndTimeToInvoiceGeneratorShouldReturnTotalFare()
        {
            double cabRunningDistance = 5.0;
            double cabRunningTime = 2.0;
            InvoiceGenerator invoice = new InvoiceGenerator(cabRunningDistance, cabRunningTime);
            Assert.AreEqual(52, invoice.CalculateCabFare());
        }
    }
}