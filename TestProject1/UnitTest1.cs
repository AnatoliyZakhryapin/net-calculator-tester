using net_calculator_tester;
using Newtonsoft.Json.Linq;

namespace TestProject1
{
    public class ClaculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(2.02f, 2.02f, 4.04f)]
        public void TestAdd(float a, float b, float result)
        {
            float functionResult = Calculator.Add(a, b);
            float expectedValue = result;
            Assert.AreEqual(result, functionResult, $"La somma deve essere {expectedValue}");
        }

        [Test]
        [TestCase(4.04f, 2.02f, 2.02f)]
        public void TestSubtract(float a, float b, float result)
        {
            float functionResult = Calculator.Subtract(a, b);
            float expectedValue = result;
            Assert.AreEqual(result, functionResult, $"Il risultato deve essere {expectedValue}");
        }

        [Test]
        [TestCase(4.04f, 2.02f, 2.00f)]
        public void TestDivide(float a, float b, float result)
        {
            float functionResult = Calculator.Divide(a, b);
            float expectedValue = result;
            Assert.AreEqual(result, functionResult, $"Il risultato deve essere {expectedValue}");
        }
    }
}