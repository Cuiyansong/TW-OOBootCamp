using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class OOBootCampTest
    {

        [TestMethod]
        public void Should_not_euqal_with_length_one_and_two()
        {
            OOLength l1 = new OOLength(1, "m");
            OOLength l2 = new OOLength(2, "m");
            Assert.AreNotEqual(l1, l2);
        }

        [TestMethod]
        public void Should_euqal_with_length_one_and_one()
        {
            OOLength l1 = new OOLength(1, "cm");
            OOLength l2 = new OOLength(1, "cm");
            Assert.AreEqual(l1, l2);
        }

        [TestMethod]
        public void should_equal_compare_1m_with_100cm()
        {
            var ooLength1m = new OOLength(1, "m");
            var ooLength100cm = new OOLength(100, "cm");
            Assert.AreEqual(ooLength1m, ooLength100cm);
        }

        [TestMethod]
        public void should_not_equal_compare_1m_with_1cm()
        {
            var ooLength1m = new OOLength(1, "m");
            var ooLength1cm = new OOLength(1, "cm");
            Assert.AreNotEqual(ooLength1m, ooLength1cm);
        }
    }
}
