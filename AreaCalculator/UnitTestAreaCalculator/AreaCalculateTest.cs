using AreaCalculator;
using AreaCalculator.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace UnitTestApp.Tests
{
    public class AreaCalculator
    {
        [Fact]
        public void CircleLessThanZeroTest()
        {
            // Arrange
            double radius = -1;

            // Act
            Action act = () => Calculator.GetCircleArea(radius);

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }

        [Fact]
        public void CircleTest()
        {
            // Arrange
            double radius = 1;

            // Act
            double result = Calculator.GetCircleArea(radius);

            // Assert
            Assert.Equal(3.142, Math.Round(result, 3));
        }

        [Fact]
        public void CircleZeroTest()
        {
            // Arrange
            double radius = 0;

            // Act
            Action act = () => Calculator.GetCircleArea(radius);

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }

        [Fact]
        public void CirleNullNullTest()
        {
            // Arrange
            Circle circle = null;

            // Act
            Action act = () => Calculator.GetArea(circle);

            // Assert
            Assert.Throws<NullReferenceException>(act);
        }


        [Fact]
        public void ListShapesTest()
        {
            // Arrange
            Circle circle = new Circle() { Radius = 1 };
            Triangle triangle = new Triangle() { AB = 3, BC = 4, CA = 5 };
            List<IShape> shapes = new List<IShape> { circle, triangle };

            // Act
            var areas = shapes.Select(t => Calculator.GetArea(t)).ToList();

            // Assert
            Assert.Equal(3.142, Math.Round(areas[0], 3));
            Assert.Equal(6, areas[1]);
        }

        [Fact]
        public void TriangleIsNotRight()
        {
            // Arrange
            double ab = 25;
            double bc = 17;
            double ca = 12;

            // Act
            bool result = Calculator.IsRightTriangle(ab, bc, ca);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TriangleIsRight()
        {
            // Arrange
            double ab = 5;
            double bc = 12;
            double ca = 13;

            // Act
            bool result = Calculator.IsRightTriangle(ab, bc, ca);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TriangleLessThanZeroTest()
        {
            // Arrange
            double ab = -3;
            double bc = -4;
            double ca = 5;

            // Act
            Action act = () => Calculator.GetTriangleArea(ab, bc, ca);

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }

        [Fact]
        public void TriangleNotExistsTest()
        {
            // Arrange
            double ab = 4.123123;
            double bc = 4.33333333;
            double ca = 9.12312;

            // Act
            Action act = () => Calculator.GetTriangleArea(ab, bc, ca);

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }

        [Fact]
        public void TriangleTest()
        {
            // Arrange
            double ab = 5;
            double bc = 5;
            double ca = 6;

            // Act
            double result = Calculator.GetTriangleArea(ab, bc, ca);

            // Assert
            Assert.Equal(12, result);
        }

        [Fact]
        public void TriangleZeroTest()
        {
            // Arrange
            double ab = 0;
            double bc = 0;
            double ca = 0;

            // Act
            Action act = () => Calculator.GetTriangleArea(ab, bc, ca);

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }
    }
}