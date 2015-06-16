using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using David.Wells.Geometry;
using David.Wells.Geometry.Models;
using David.Wells.Geometry.Controllers;
using Moq;
using David.Wells.Geometry.Services;
namespace David.Wells.Geometry.Tests.Controllers
{
    [TestClass]
    public class QuadrilateralControllerTest
    {
        [TestMethod]
        ///<summary>
        /// Negative test
        ///</summary>
        public void Quadrilateral_NegativeTest()
        {
            // Arrange
            Mock<QuadrilateralService> mockedService = new Mock<QuadrilateralService>();

            QuadrilateralController controller = new QuadrilateralController(mockedService.Object);
            Quadrilateral model = new Quadrilateral(0, 0, 0, 0);
            // Act
            JsonResult result = controller.GetQuadilateralType(model) as JsonResult;

            // Assert
            Assert.AreEqual(result.Data, QuadrilateralType.None);
        }

        [TestMethod]
        ///<summary>
        ///Positive test - Square
        ///</summary>
        public void Quadrilateral_Square()
        {
            // Arrange
            IQuadrilateralService mockedService = new QuadrilateralService();

            QuadrilateralController controller = new QuadrilateralController(mockedService);
            Quadrilateral model = new Quadrilateral(5, 5, 5, 5);
            // Act
            JsonResult result = controller.GetQuadilateralType(model) as JsonResult;

            // Assert
            Assert.AreEqual(result.Data, QuadrilateralType.Rhombus);
        }
    }
}
