using NUnit.Framework;
using System;

namespace UnitTestPractics.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void AdditionalAlwaysReturnsExpectedValue()
        {
            var calculator = new Calculator();

            Assert.That(calculator.Additional(100, 100), Is.EqualTo(200));
        }

        [Test]
        public void SubstractionMustReturnNotNullValue()
        {
            var calculator = new Calculator();

            Assert.True(calculator.Subtraction(5, 4) == 1);
        }

        [Test]
        public void MultiplicationMustReturnNotNullValue()
        {
            var calculator = new Calculator();

            Assert.AreEqual(8, calculator.Miltiplication(2, 4));
        }

        [Test]
        public void DivisionMustReturnNotNullValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(8, 4) == 2);
        }

        [Test]
        public void Division_MustThrowException()
        {
            var calculator = new Calculator();

            Assert.Throws<DivideByZeroException>(() => calculator.Division(2, 0));
        }

    }
}
