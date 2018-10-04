using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Datediff;
using Datediff.Controllers;
using Datediff.Models;

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
        public void GetDifferenceWithValidDates()
        {
            // Arrange
            DateDiffController controller = new DateDiffController();
            DateViewModel model = new DateViewModel()
            {
                FromDate = "02/02/2018",
                ToDate = "04/02/2018"
            };
            // Act
            ViewResult result = controller.OnSubmit(model) as ViewResult;

            // Assert
            Assert.IsNotNull(result);

            var resultModel = result.Model as DateViewModel;
            Assert.AreEqual(resultModel.TotalDays, 2);
        }

        [TestMethod]
        public void InvalidDate()
        {
            DateDiffController controller = new DateDiffController();

            DateViewModel model = new DateViewModel()
            {
                FromDate = "02/02",
                ToDate = "02/02/2018"
            };
            // Act
            ViewResult result = controller.OnSubmit(model) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            var resultModel = result.Model as DateViewModel;

            Assert.AreEqual(controller.ModelState["FromDate"].Errors[0].ErrorMessage, "Please Enter Valid Date in dd/MM/yyyy format");
        }

        [TestMethod]
        public void FromDateLessThanToDate()
        {
            DateDiffController controller = new DateDiffController();

            DateViewModel model = new DateViewModel()
            {
                FromDate = "02/02/2018",
                ToDate = "01/02/2018"
            };
            // Act
            ViewResult result = controller.OnSubmit(model) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            var resultModel = result.Model as DateViewModel;
            Assert.AreEqual(controller.ModelState["FromDate"].Errors[0].ErrorMessage, "From Date should be less than To Date");
        }

        [TestMethod]
        public void NoInputProvided()
        {
            DateDiffController controller = new DateDiffController();

            DateViewModel model = new DateViewModel()
            {
                FromDate = "",
                ToDate = ""
            };
            // Act
            ViewResult result = controller.OnSubmit(model) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            var resultModel = result.Model as DateViewModel;
            Assert.AreEqual(controller.ModelState["FromDate"].Errors[0].ErrorMessage, "Please Enter Valid Date in dd/MM/yyyy format");

        }

    }
}
