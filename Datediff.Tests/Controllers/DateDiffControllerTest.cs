using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Datediff;
using Datediff.Controllers;

namespace Datediff.Tests.Controllers
{
    [TestClass]
    public class DateDiffControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            DateDiffController controller = new DateDiffController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            DateDiffController controller = new DateDiffController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            DateDiffController controller = new DateDiffController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
