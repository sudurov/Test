using AreaCalculator.Helpers;
using System;

namespace AreaCalculator.Shapes
{
    /// <summary>
    /// Triangle shape
    /// </summary>
    public class Triangle : IShape
    {
        #region Private fields

        private double _ab;
        private double _bc;
        private double _ca;

        #endregion

        #region Properties

        /// <summary>
        /// One of three sides
        /// </summary>
        public double AB
        {
            get { return _ab; }
            set
            {
                CommonHelper.CheckGreaterThanZero(value, "Triangle side");
                _ab = value;
            }
        }

        /// <summary>
        /// One of three sides
        /// </summary>
        public double BC
        {
            get { return _bc; }
            set
            {
                CommonHelper.CheckGreaterThanZero(value, "Triangle side");
                _bc = value;
            }
        }

        /// <summary>
        /// One of three sides
        /// </summary>
        public double CA
        {
            get { return _ca; }
            set
            {
                CommonHelper.CheckGreaterThanZero(value, "Triangle side");
                _ca = value;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor without arguments. Use sides length = 1 by default
        /// </summary>
        public Triangle() : this(3, 4, 5)
        {
        }

        /// <summary>
        /// Constructor with sides length params
        /// </summary>
        /// <param name="ab"></param>
        /// <param name="bc"></param>
        /// <param name="ca"></param>
        public Triangle(double ab, double bc, double ca)
        {
            AB = ab;
            BC = bc;
            CA = ca;

            CheckTriangleExistence();
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Get Area
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            var p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA));
        }


        /// <summary>
        /// Get Area
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            return IsRightTriangleBySides(AB, BC, CA) ||
                   IsRightTriangleBySides(BC, AB, CA) ||
                   IsRightTriangleBySides(CA, BC, AB);
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Get triangle perimeter
        /// </summary>
        /// <returns></returns>
        private double GetPerimeter()
        {
            return AB + BC + CA;
        }

        /// <summary>
        /// Chek triangle existence
        /// </summary>
        private void CheckTriangleExistence()
        {
            if (AB + BC > CA && AB + CA > BC && BC + CA > AB) return;

            throw new ArgumentOutOfRangeException(
                $"Triangle with sides: AB = {AB}, BC= {BC}, CA= {CA} does not exist");
        }



        /// <summary>
        /// Chek triangle existence
        /// </summary>
        private bool IsRightTriangleBySides(double ab, double bc, double ca)
        {
            return Math.Pow(ab, 2) == Math.Pow(bc, 2) + Math.Pow(ca, 2);
        }

        #endregion
    }
}