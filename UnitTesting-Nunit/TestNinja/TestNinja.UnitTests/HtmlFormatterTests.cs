using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestNinja.UnitTests
{   
    [TestFixture]
    class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new Fundamentals.HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));

            //To general
            Assert.That(result, Does.StartWith("<strong>"));

            
        }
    }
}
