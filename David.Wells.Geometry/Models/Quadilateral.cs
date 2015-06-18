using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace David.Wells.Geometry.Models
{
    public enum QuadrilateralType
    {
        None,
        ParralellogramOrRectangle,
        SquareOrRhombus,
        Trapezium,
        Kite,
    }

    public class Quadrilateral
    {
    
        /// <summary>
        /// Represents a quadrilateral.
        /// </summary>
        /// <param name="sideA">Side A. Adjacent to side D and B.  Opposes C</param>
        /// <param name="sideB">Side B. Adjacent to side A and C.  Opposes D</param>
        /// <param name="SideC">Side C. Adjacent to side B and D.  Opposes A</param>
        /// <param name="sideD">Side D. Adjacent to side C and A.  Opposes B) </param>
        public Quadrilateral(int sideA, int sideB, int sideC, int sideD)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
        }

        /// <summary>
        /// Opposes side C
        /// </summary>
        public int SideA { get; set; }

        /// <summary>
        /// Opposes side D
        /// </summary>
        public int SideB { get; set; }

        /// <summary>
        /// Opposes side A
        /// </summary>
        public int SideC { get; set; }

        /// <summary>
        /// Opposes side B
        /// </summary>
        public int SideD { get; set; }

    }
}