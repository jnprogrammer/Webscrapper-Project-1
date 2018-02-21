﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowArgumentOutOfRangeExemption(int speed)
        {
            var calculator = new Fundamentals.DemeritPointsCalculator();

            Assert.That(() => calculator.CalculateDemeritPoints(speed),Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
            
        }

       
        [Test]  
        [TestCase(0,0)]
        [TestCase(64,0)]
        [TestCase(65,0)]
        [TestCase(66,0)]
        [TestCase(70,1)]
        [TestCase(75,2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
        {
            var calculator = new Fundamentals.DemeritPointsCalculator();
            var points = calculator.CalculateDemeritPoints(speed);

            Assert.That(points, Is.EqualTo(expectedResult));
        }

        //[Test]
        //public void CalculateDemeritPoints_SpeedIsLessThanSpeedLimit_ReturnZero()
        //{

        //}
    }
}
