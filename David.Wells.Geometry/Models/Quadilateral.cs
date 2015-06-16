using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace David.Wells.Geometry.Models
{
    public enum QuadrilateralType
    {
        None,
        Parralellogram,
        Rectangle,
        Rhombus,
        Trapezium,
        Kite
    }

    public class Quadrilateral
    {
    
        public Quadrilateral(int side1, int side2, int side3, int side4)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Side4 = side4;
        }
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }

    
    }
}