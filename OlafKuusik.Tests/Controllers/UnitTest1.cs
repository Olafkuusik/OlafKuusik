using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OlafKuusik;
using OlafKuusik.Controllers;

namespace OlafKuusik.Tests.Controllers
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void SumTestMethod()
        {
            CalcController controller = new CalcController();

            int result = controller.Sum(100, 5);

            Assert.AreEqual(result, 105);
        }

        [TestMethod]
        public void SubstractTestMethod()
        {
            CalcController controller = new CalcController();

            int result = controller.Substract(100, 5);

            Assert.AreEqual(result, 95);
        }

        [TestMethod]
        public void MultiplyTestMethod()
        {
            CalcController controller = new CalcController();

            int result = controller.Multiply(100, 5);

            Assert.AreEqual(result, 500);
        }

        [TestMethod]
        public void DivideTestMethod()
        {
            CalcController controller = new CalcController();

            int result = controller.Divide(100, 5);

            Assert.AreEqual(result, 20);
        }
    }
}
