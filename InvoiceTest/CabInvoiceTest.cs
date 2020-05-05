///--------------------------------------------------------------------
///   Class:       Tests
///   Description: Cointains test method to check Cab Invoice. 
///   Author:      Nitikesh Shinde                   Date: 05/05/2020
///--------------------------------------------------------------------

using NUnit.Framework;
using CabInvoiceGenerator;
using System;

namespace CabInvoiceTest
{
    public class Tests
    {
        InvoiceGenerator invoice = new InvoiceGenerator();

        [SetUp]
        public void Setup()
        {
        }

        /// <test 1>
        /// Creating an object of InvoiceGenerator
        /// sending two parameters as cabRunningDistance and canRunningTime
        /// returning TotalFare and checking with expected fare
        /// </test 1>
        [Test]
        public void GivenDistanceAndTimeToInvoiceGeneratorShouldReturnTotalFare()
        {
            Assert.AreEqual(52, invoice.CalculateCabFare(5.0, 2.0));
        }

        /// <test 2>
        /// Creating an object of InvoiceGenerator
        /// sending two parameters as cabRunningDistance and canRunningTime
        /// </test 2>
        [Test]
        public void GivenDistanceAndTimeOfMultiRidesToInvoiceGeneratorShouldReturnTotalFare()
        {
            //Custom Arrray of Ride class
            Ride[] rides =
                {
                new Ride(2.0,1.0),
                new Ride(2.5,1.5)
                };
            var exceptedSummery = 47.5;
            InvoiceSummery returnSummery = invoice.CalculateCabFare(rides);
            Assert.AreEqual(exceptedSummery, returnSummery.totalFare);
        }

        /// <test 3>
        /// Creating an object of InvoiceGenerator
        /// sending two parameters as cabRunningDistance and canRunningTime
        /// - Total Number of Rides- Total Fare- Average Fare Per Ride
        /// </test 3>
        [Test]
        public void GivenDistanceAndTimeOfMultiRidesToInvoiceGeneratorShouldInhancedInvoice()
        {      
            // Local variables
            bool exceptedInvoice = true;
            bool returnInvoice = false;
            // sending two rides distance in double and also time in double
            Ride[] rides =
            {
                new Ride(2.0,1.0),
                new Ride(2.5,1.5)
            };
            InvoiceSummery returnSummery = invoice.CalculateCabFare(rides);
            InvoiceSummery expectedSummery = new InvoiceSummery
            {
                totalNumberOfRides = 2,
                totalFare = 47.5,
                averageFarePerRide = 23.75
            };
            //Checkoing all three returnSummary values are equal to exceptedSummary
            //iF yes then returnInvoice will be 'true'
            if (returnSummery.totalNumberOfRides == expectedSummery.totalNumberOfRides && returnSummery.totalFare == expectedSummery.totalFare && returnSummery.averageFarePerRide == expectedSummery.averageFarePerRide)
            {
                returnInvoice = true;
            }
            Assert.AreEqual(exceptedInvoice, returnInvoice);           
        }
    }
}