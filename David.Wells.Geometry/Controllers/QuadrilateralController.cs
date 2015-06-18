using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using David.Wells.Geometry.Models;
using David.Wells.Geometry.Services;
using System.Net;

namespace David.Wells.Geometry.Controllers
{
    public class QuadrilateralController : Controller
    {
        private readonly IQuadrilateralService service;
        private const string validationMsg = "All sides must have a length greater than 0";

        public QuadrilateralController(IQuadrilateralService quadrilateralService)
        {
            service = quadrilateralService;
        }

        public ActionResult GetQuadilateralType(Quadrilateral model)
        {
            return getQuadrilateralType(model);
        }

        private ActionResult getQuadrilateralType(Quadrilateral model)
        {
            if (!service.ValidateSides(model))
            {
                return new System.Web.Mvc.HttpStatusCodeResult(500, validationMsg);
            }

            return Json(service.DetermineType(model));
        }

        public ActionResult GetQuadilateralType (int side1, int side2, int side3, int side4)
        {
            Quadrilateral model = new Quadrilateral(side1, side2, side3, side4);

            return getQuadrilateralType(model);
        }
    }
}