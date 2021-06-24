using Moq;
using NUnit.Framework;
using System;

namespace Phase4_2_12_DynamicFakes.Tests
{
    [TestFixture]
    public class Class1
    {

        [Test]
        public void DynamicFake()
        {
            int x = 10, y = 20;
            Mock<IDynamicCalc> mockCalc = new Mock<IDynamicCalc>();
            var result = new
            {
                V = 50// Convert.ToInt32(x + y)
            };

            mockCalc.Setup(c => c.add(It.IsAny<object>(), It.IsAny<object>())).Returns(result);
            var resutl = mockCalc.Object.add(1, 2);
            Console.WriteLine(resutl);
        }

    }
}
