﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Fundamentals.Math _math;
        //Setup

        
        [SetUp]
        public void SetUp()
        {
            _math = new Fundamentals.Math();
        }
        //TearDown


        [Test]
        [Ignore("Because Carmine is a Gear!")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
    
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]   
        [TestCase(2,1,2)]
        [TestCase(1,2,2)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
           var result = _math.GetOddNumbers(3);

            /*Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count(), Is.EqualTo(3));

            Assert.That(result, Does.Contain(1));
            Assert.That(result, Does.Contain(3));
            Assert.That(result, Does.Contain(5));*/

            Assert.That(result, Is.EquivalentTo(new[] { 1, 2, 3 }));

           // Assert.That(result, Is.Ordered);
           // Assert.That(result, Is.Unique);

        }
    }
}
