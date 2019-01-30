using DotNet_Fundamentals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Types
{
    [TestClass]
    public class Classes
    {
        [TestMethod]
        public void MyTestMethod()
        {
            Cookies cookie = new Cookies();
            cookie.Name = "Snickerdoodles";
            cookie.GlutenFree = false;
            cookie.BatchSize = 24;

            Cookies cookieTwo = new Cookies();
            cookieTwo.Name = "Chocolate Chip";
            cookieTwo.BatchSize = 36;
            cookieTwo.GlutenFree = true;

            Assert.AreEqual("Chocolate Chip", cookieTwo.Name);
            Assert.AreEqual(36, cookieTwo.BatchSize);
            Assert.AreEqual(true, cookieTwo.GlutenFree);


            Assert.AreEqual("Snickerdoodles", cookie.Name);
            Assert.AreEqual(24, cookie.BatchSize);
            Assert.AreEqual(false, cookie.GlutenFree);

        }
    }
}
