using AreaCalculator.Shapes;

namespace AreaCalculator
{
    /// <summary>
    /// Class, provides calculate shapes area
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Get circle area by radius test
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double GetCircleArea(double radius)
        {
            Circle circle = new Circle(radius);

            return circle.GetArea();
        }

        /// <summary>
        /// Get triangle area by three sides
        /// </summary>
        /// <param name="ab"></param>
        /// <param name="bc"></param>
        /// <param name="ca"></param>
        /// <returns></returns>
        public static double GetTriangleArea(double ab, double bc, double ca)
        {
            Triangle triangle = new Triangle(ab, bc, ca);

            return triangle.GetArea();
        }

        /// <summary>
        /// Check is right triangle
        /// </summary>
        /// <param name="ab"></param>
        /// <param name="bc"></param>
        /// <param name="ca"></param>
        /// <returns></returns>
        public static bool IsRightTriangle(double ab, double bc, double ca)
        {
            Triangle triangle = new Triangle(ab, bc, ca);

            return triangle.IsRightTriangle();
        }

        /// <summary>
        /// Get area from class implemented IShape
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        public static double GetArea(IShape shape)
        {
            if (shape == null)
            {
                throw new System.NullReferenceException("The shape can't be null");
            }

            return shape.GetArea();
        }
    }
}
