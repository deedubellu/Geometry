using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using David.Wells.Geometry;
using David.Wells.Geometry.Models;
using David.Wells.Geometry.Controllers;
using Moq;
using David.Wells.Geometry.Services;
using System.Web.Mvc;
namespace David.Wells.Geometry.Tests.Controllers
{
    [TestClass]
    public class QuadrilateralControllerTest
    {
        Mock<QuadrilateralService> mockedService;
        
        [TestInitialize]
        public void Setup()
        {
            mockedService = new Mock<QuadrilateralService>();
        }

        [TestMethod]
        ///<summary>
        /// Negative test
        ///</summary>
        public void Quadrilateral_NegativeTest()
        {
            // Arrange
            QuadrilateralController controller = new QuadrilateralController(mockedService.Object);
            
            Quadrilateral model = new Quadrilateral(0, 0, 0, 0);
            // Act
            var result = controller.GetQuadilateralType(model);

            // Assert
            Assert.IsInstanceOfType(result, typeof(HttpStatusCodeResult));

            HttpStatusCodeResult statusResult = result as HttpStatusCodeResult;

            Assert.AreEqual(statusResult.StatusCode, 500);
            Assert.AreEqual(statusResult.StatusDescription, "All sides must have a length greater than 0");
        }

        [TestMethod]
        ///<summary>
        ///Positive tests
        ///</summary>
        public void Quadrilateral_Positivies()
        {
            // Arrange
            QuadrilateralController controller = new QuadrilateralController(mockedService.Object);
            Dictionary<QuadrilateralType, Quadrilateral> quadrilaterals = new Dictionary<QuadrilateralType, Quadrilateral>();

            quadrilaterals.Add(QuadrilateralType.SquareOrRhombus, new Quadrilateral(10, 10, 10, 10));
            quadrilaterals.Add(QuadrilateralType.Trapezium, new Quadrilateral(10, 12, 20, 18));
            quadrilaterals.Add(QuadrilateralType.Kite, new Quadrilateral(10, 20, 20, 10));
            quadrilaterals.Add(QuadrilateralType.ParralellogramOrRectangle, new Quadrilateral(10, 20, 20, 10));

            foreach (KeyValuePair<QuadrilateralType, Quadrilateral> item in quadrilaterals)
            {
                // Act
                var actual = controller.GetQuadilateralType(item.Value);

                // Assert
                Assert.IsInstanceOfType(actual, typeof(JsonResult));

                JsonResult result = actual as JsonResult;

                Assert.AreEqual(result.Data, item.Key);
            }
        }

    }
}
