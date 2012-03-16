using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{
		//TODO Task 7 items go here
        [Test()]
        public void TestThatFlightInitializes()
        {
            var target = new Flight(new DateTime(2010, 1, 18), new DateTime(2010, 2, 18), 67);
            Assert.IsNotNull(target);
        }

        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestNoTimeTravel()
        {
            new Flight(new DateTime(2010, 2, 18), new DateTime(2010, 1, 18), 67);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestNegativeDistance()
        {
            new Flight(new DateTime(2010, 1, 18), new DateTime(2010, 2, 18), -67);
        }

        [Test()]
        public void TestOneDaySpan()
        {
            var target = new Flight(new DateTime(2010, 1, 18), new DateTime(2010, 1, 19), 67);
            Assert.AreEqual(220, target.getBasePrice());
        }

        [Test()]
        public void TestTwoDaySpan()
        {
            var target = new Flight(new DateTime(2010, 1, 18), new DateTime(2010, 1, 20), 67);
            Assert.AreEqual(240, target.getBasePrice());
        }

        [Test()]
        public void TestThreeDaySpan()
        {
            var target = new Flight(new DateTime(2010, 1, 18), new DateTime(2010, 1, 21), 67);
            Assert.AreEqual(260, target.getBasePrice());
        }

        [Test()]
        public void TestTenDaySpan()
        {
            var target = new Flight(new DateTime(2010, 1, 18), new DateTime(2010, 1, 2), 67);
            Assert.AreEqual(400, target.getBasePrice());
        }


	}
}
