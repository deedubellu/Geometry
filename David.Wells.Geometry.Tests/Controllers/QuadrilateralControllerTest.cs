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
        [TestMethod]
        ///<summary>
        /// Negative test
        ///</summary>
        public void Quadrilateral_NegativeTest()
        {
            // Arrange
            Mock<QuadrilateralService> mockedService = new Mock<QuadrilateralService>();
//            Mock<HttpContextBase> httpContext = new Mock<HttpContextBase>();

            QuadrilateralController controller = new QuadrilateralController(mockedService.Object);
            
            Quadrilateral model = new Quadrilateral(0, 0, 0, 0);
            // Act
            var result = controller.GetQuadilateralType(model) as JsonResult;

            // Assert
            Assert.IsInstanceOf(result, typeof(HttpStatusCodeResult));
            
            HttpStatusCodeResult statusResult = result as HttpStatusCodeResult();

            Assert.AreEqual(statusResult.StatusCode, 500);
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
            var result = controller.GetQuadilateralType(model);

            // Assert
            Assert.AreEqual(result.Data, QuadrilateralType.Rhombus);
        }
    }
}
