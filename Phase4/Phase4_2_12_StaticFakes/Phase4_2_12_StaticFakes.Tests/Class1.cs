using NUnit.Framework;
using System;

namespace Phase4_2_12_StaticFakes.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void StaticFake()
        {
            int x = 10, y = 20;
            var wrapper = new SCalcWrapper();
            Assert.That(wrapper.add(x, y), Is.EqualTo(x + y));
        }

    }

}
