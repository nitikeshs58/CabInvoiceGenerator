///--------------------------------------------------------------------
///   Class:       Tests
///   Description: Cointains test method to check Cab Invoice. 
///   Author:      Nitikesh Shinde                   Date: 05/05/2020
///--------------------------------------------------------------------

using NUnit.Framework;
using CabInvoiceGenerator;
using System.Collections.Generic;

namespace CabInvoiceTest
{
    public class Tests
    {
        InvoiceGenerator invoice = new InvoiceGenerator();
        RideRepository rideRepository = new RideRepository();

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
            Assert.AreEqual(52, invoice.CalculateCabFare("normal",5.0, 2.0));
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
                new Ride("normal",2.0,1.0),
                new Ride("normal",2.5,1.5)
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
            // sending two rides distance in double and also time in double
            Ride[] rides =
            {
                new Ride("normal",2.0,1.0),
                new Ride("normal",2.5,1.5)
            };
            InvoiceSummery returnSummery = invoice.CalculateCabFare(rides);
            InvoiceSummery expectedSummery = new InvoiceSummery
            {
                totalNumberOfRides = 2,
                totalFare = 47.5,
                averageFarePerRide = 23.75
            };
            Assert.AreEqual(returnSummery.totalFare, expectedSummery.totalFare);
            Assert.AreEqual(expectedSummery.totalNumberOfRides,returnSummery.totalNumberOfRides);
            Assert.AreEqual(expectedSummery.averageFarePerRide,returnSummery.averageFarePerRide);        
        }

        /// <Test 4>
        /// Invoice Service
        /// Given a user id, the Invoice Service gets the List of rides from the RideRepository,
        /// and returns avergae of normalFare.
        /// </Test 4>
        [Test]
        public void GivenDistanceAndTimeOfMultiRidesToUserIdShouldTotalFare()
        {
            string userId = "nit@123";
            Ride[] rides =
            {
                new Ride("normal",2.0,1.0),
                new Ride("normal",2.5,1.5)
            };
            rideRepository.AddRides(userId, rides);
            InvoiceSummery retunTotal = invoice.CalculateCabFare(rideRepository.GetRides(userId));
            Assert.AreEqual(47.5, retunTotal.totalFare);
        }

        /// <Test 5>
        /// Invoice Service
        /// Given a user id, will have 'normal' and 'premimun' ridethe Invoice Service gets the List of rides from the RideRepository,
        /// and returns Total Average of normalFare and premimumFare.
        /// </Test 5>
        [Test]
        public void GivenUserIdOfMultiRidesToUserIdShouldTotalFare()
        {
            string userId = "Raj@123";
            Ride[] rides =
            {
                new Ride("normal",2.0,1.0),
                new Ride("premium",2.5,1.5)
            };
            rideRepository.AddRides(userId, rides);
            InvoiceSummery retunTotal = invoice.CalculateCabFare(rideRepository.GetRides(userId));
            Assert.AreEqual(61.5, retunTotal.totalFare);
        }
    }
}