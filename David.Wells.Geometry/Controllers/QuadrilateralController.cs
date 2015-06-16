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
        
        public QuadrilateralController(IQuadrilateralService quadrilateralService)
        {
            service = quadrilateralService;
        }

        public JsonResult GetQuadilateralType(Quadrilateral model)
        {
            if (model.Side1 == 0 || model.Side2 == 0 || model.Side3 == 0 || model.Side4 == 0)
            {
                throw new Exception("all sides must have a length greater than 0");
            }
                
            return Json(service.DetermineType(model));
        }



        public JsonResult GetQuadilateralType (int side1, int side2, int side3, int side4)
        {
            Quadrilateral model = new Quadrilateral(side1, side2, side3, side4);

            return new JsonResult() { Data = service.DetermineType(model), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}