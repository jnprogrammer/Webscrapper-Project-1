using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class FizzBuzzTests
    {
        [Test]
        public void GetOutPut_InputIsDivisibleBy3and5_ReturnFizzBuzz()
        {
            var result = Fundamentals.FizzBuzz.GetOutput(15);
            Assert.That(result, Is.EqualTo("FizzBuzz"));

           
        }

        [Test]
        public void GetOutPut_InputIsDivisibleBy3Only_ReturnFizz()
        {
            var result = Fundamentals.FizzBuzz.GetOutput(3);
            Assert.That(result, Is.EqualTo("Fizz"));
        }
        
        [Test]
        public void GetOutPut_InputIsDivisibleBy5Only_ReturnBuzz()
        {
            var result = Fundamentals.FizzBuzz.GetOutput(5);
            Assert.That(result, Is.EqualTo("Buzz"));
        }
       
        [Test]
        public void GetOutPut_InputIsNotDivisibleBy30or5_ReturnTheSameNumber()
        {
            var result = Fundamentals.FizzBuzz.GetOutput(1);
            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
