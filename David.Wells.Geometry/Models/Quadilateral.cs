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
        ParralellogramOrRectangle,
        Rhombus,
        Square,
        RhombusOrSquare,
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
        /// <param name="angleAB">Joins side A and B.  Opposes angle CD</param>
        /// <param name="angleBC">Joins side B and C.  Opposes angle DA</param>
        /// <param name="angleCD">Joins side C and D.  Opposes angle AB</param>
        /// <param name="angleDA">Joins side D and A.  Opposes angle BC</param>
        public Quadrilateral(int sideA, int sideB, int sideC, int sideD, int angleAB, int angleBC, int angleCD, int angleDA)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;

            AngleAB = angleAB;
            AngleBC = angleBC;
            AngleCD = angleCD;
            AngleDA = angleDA;
        }
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }
        public int SideD { get; set; }


        public int AngleAB { get; set; }

        public int AngleDA { get; set; }

        public int AngleCD { get; set; }

        public int AngleBC { get; set; }
    }
}