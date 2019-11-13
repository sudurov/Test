using AreaCalculator.Helpers;
using System;

namespace AreaCalculator.Shapes
{
    /// <summary>
    /// Cirle shape
    /// </summary>
    public class Circle : IShape
    {
        #region Private fields

        private double _radius;

        #endregion

        #region Properties

        /// <summary>
        /// Get/Set radius property
        /// </summary>
        public double Radius {
            get { return _radius; }
            set
            {
                CommonHelper.CheckGreaterThanZero(value, "Radius");
                _radius = value;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor without arguments. Use redius = 1 by default
        /// </summary>
        public Circle() : this(1)
        {
        }

        /// <summary>
        /// Constructor with radius param
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Get Area
        /// </summary>
        /// <returns>Triangle area</returns>
        public double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        #endregion
    }
}
