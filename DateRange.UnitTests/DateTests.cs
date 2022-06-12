using NUnit.Framework;
using System;

namespace DateRange.UnitTests
{
    class DateTests
    {
        [Test]
        public void GenerateDate_WhenCalled_ShouldReturnDate()
        {
            var result = new DateTime(2017, 01, 01);
            string[] args = { "01.01.2017", "01/01/2017", "2017-01-01" };
            DateTime[] temp = new DateTime[3];
            Date.GenerateDate(args ,temp);
            for (int i = 0; i < args.Length; i++)
            {
                Assert.That(result, Is.EqualTo(temp[i]));
            }
        }
        [Test]
        public void WriteDates_WhenCalled_ShouldReturnDates1()
        {
            var expected = "01 - 05.01.2017";
            string[] args = { "01.01.2017", "05.01.2017"};
            DateTime[] temp = { new DateTime(2017, 01, 01), new DateTime(2017, 01, 05) };
            string result = Date.WriteDates(args, temp);
            Assert.That(expected, Is.EqualTo(result));
        }
        [Test]
        public void WriteDates_WhenCalled_ShouldReturnDates2()
        {
            var expected = "01/01 - 05/02/2017";
            string[] args = { "01/01/2017", "05/02/2017" };
            DateTime[] temp = { new DateTime(2017, 01, 01), new DateTime(2017, 02, 05) };
            string result = Date.WriteDates(args, temp);
            Assert.That(expected, Is.EqualTo(result));
        }
        [Test]
        public void WriteDates_WhenCalled_ShouldReturnDates3()
        {
            var expected = "2016-01-01 - 2017-01-05";
            string[] args = { "2016-01-01", "2017-01-05" };
            DateTime[] temp = { new DateTime(2016, 01, 01), new DateTime(2017, 01, 05) };
            string result = Date.WriteDates(args, temp);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}