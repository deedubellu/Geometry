using David.Wells.Geometry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace David.Wells.Geometry.Services
{
    public interface IQuadrilateralService
    {
        QuadrilateralType DetermineType(Quadrilateral model);

        bool ValidateSides(Quadrilateral model);
    }

    /// <summary>
    /// Service for determining simple (non-intersecting quadrilater types)
    /// </summary>
    public class QuadrilateralService : IQuadrilateralService
    {

        public QuadrilateralService()
        {
        }

        public QuadrilateralType DetermineType(Quadrilateral model)
        {
            QuadrilateralType result = QuadrilateralType.None;

            if (isSquareOrRhombus(model))
                result = QuadrilateralType.SquareOrRhombus;
            else if (isTrapezium(model))
                result = QuadrilateralType.Trapezium;
            else if (isParralellogramOrRectangle(model))
                result = QuadrilateralType.ParralellogramOrRectangle;
            else if (isKite(model))
                result = QuadrilateralType.Kite;

            return result;
        }

        private bool isKite(Quadrilateral model)
        {
            return model.SideA == model.SideB &&
                model.SideC == model.SideD &&
                model.SideB != model.SideC;
        }

        private bool isTrapezium(Quadrilateral model)
        {
            throw new NotImplementedException();
        }

        private bool isParralellogramOrRectangle(Quadrilateral model)
        {
            return (model.SideA == model.SideC && model.SideB == model.SideD);
        }

        private bool isSquareOrRhombus(Quadrilateral model)
        {
            return (model.SideA == model.SideB &&
                model.SideA == model.SideC &&
                model.SideA == model.SideD);
        }

        public bool ValidateSides(Quadrilateral model)
        {
            return model.SideA > 0 || model.SideB > 0 || model.SideC > 0 || model.SideD > 0;
        }

    }
}