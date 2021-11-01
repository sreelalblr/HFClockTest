using FriendlyClock;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FriendtlyClockMSTest
{
    [TestClass]
    public class UnitTestTimeToFriendlyTimeConverter
    {
        private IFriendlyTimeConverter friendlyTimeConverter;

        public UnitTestTimeToFriendlyTimeConverter()
        {
            INumberToWordsConverter numberToWordsConverter = new TimeNumbersToWordConverter();
            friendlyTimeConverter = new TimeToFriendlyTimeConverter(numberToWordsConverter);
        }

        [TestMethod]
        public void TestValidFriendlyTimes()
        {
            var friendlyTime = friendlyTimeConverter.GetHumanFriendlyTime("10:30");
            Assert.IsTrue(string.Equals(friendlyTime, "Half past ten"));

            friendlyTime = friendlyTimeConverter.GetHumanFriendlyTime("11:15");
            Assert.IsTrue(string.Equals(friendlyTime, "Quarter past eleven"));


            friendlyTime = friendlyTimeConverter.GetHumanFriendlyTime("10:40");
            Assert.IsTrue(string.Equals(friendlyTime, "Twenty to eleven"));

            friendlyTime = friendlyTimeConverter.GetHumanFriendlyTime("12:00");
            Assert.IsTrue(string.Equals(friendlyTime, "Twelve O' clock"));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestExceptionWithTextforTime()
        {
            var friendlyTime = friendlyTimeConverter.GetHumanFriendlyTime("abc:30");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestExceptionWithInvalidHours24()
        {
            var friendlyTime = friendlyTimeConverter.GetHumanFriendlyTime("24:00");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestExceptionWithInvalidHours25()
        {
            var friendlyTime = friendlyTimeConverter.GetHumanFriendlyTime("25:00");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestExceptionWithInvalidMinutes()
        {
            var friendlyTime = friendlyTimeConverter.GetHumanFriendlyTime("10:60");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestExceptionWithInvalidMinutes60()
        {
            var friendlyTime = friendlyTimeConverter.GetHumanFriendlyTime("10:60");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestExceptionWithInvalidMinutes61()
        {
            var friendlyTime = friendlyTimeConverter.GetHumanFriendlyTime("10:61");
        }
    }
}
