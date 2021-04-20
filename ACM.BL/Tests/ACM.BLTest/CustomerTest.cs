using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer()
            {
                FirstName = "Felix",
                LastName = "Anducho"
            };

            string expected = "Anducho, Felix";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FirstNameEmpty()
        {
            Customer customer = new Customer()
            {
                LastName = "Anducho"
            };

            string expected = "Anducho";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void LastNameEmpty()
        {
            Customer customer = new Customer()
            {
                FirstName = "Felix"
            };

            string expected = "Felix";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void StaticTest()
        {
            Customer c1 = new Customer();
            c1.FirstName = "Felix";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Argel";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Anducho";
            Customer.InstanceCount += 1;

            Assert.AreEqual(3, Customer.InstanceCount);

        }
    }
}
