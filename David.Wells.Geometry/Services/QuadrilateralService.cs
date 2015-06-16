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
    }
    public class QuadrilateralService : IQuadrilateralService
    {
        public QuadrilateralService()
        {
        }

        public QuadrilateralType DetermineType(Quadrilateral model)
        {
            QuadrilateralType result = QuadrilateralType.None;

            if (isParralellogram(model))
                result = QuadrilateralType.Parralellogram;
            else if (isTrapezium(model))
                result = QuadrilateralType.Trapezium;
            else if (isRectangle(model))
                result = QuadrilateralType.Rectangle;
            else if (isRhombus(model))
                result = QuadrilateralType.Rhombus;
            else if (isKite(model))
                result = QuadrilateralType.Kite;

            return result;
        }

        private bool isKite(Quadrilateral model)
        {
            return model.Side1 == model.Side2 &&
                model.Side3 == model.Side4 &&
                model.Side2 != model.Side3;
        }

        private bool isRhombus(Quadrilateral model)
        {
            throw new NotImplementedException();
        }

        private bool isRectangle(Quadrilateral model)
        {
            return model.Side1 == model.Side3 &&
                model.Side2 == model.Side4 &&
                model.Side1 != model.Side2 &&
                model.Side1 != model.Side3;
        }

        private bool isTrapezium(Quadrilateral model)
        {
            throw new NotImplementedException();
        }

        private bool isParralellogram(Quadrilateral model)
        {
            return (model.Side1 == model.Side3 && model.Side2 == model.Side4);
        }

        private bool isSquare(Quadrilateral model)
        {
            return (model.Side1 == model.Side2 &&
                model.Side1 == model.Side3 &&
                model.Side1 == model.Side4);
        }
    }
}