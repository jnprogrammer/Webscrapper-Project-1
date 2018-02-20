using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; 

namespace TestNinja.UnitTests
{
    [TestFixture]
    class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new Fundamentals.CustomerController();

            var result = controller.GetCustomer(0);
             
            //Not found
            Assert.That(result, Is.TypeOf<Fundamentals.NotFound>());
            // Find a NotFound object or one of its derivatives
            Assert.That(result, Is.InstanceOf<Fundamentals.NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {

        }
    }
}
