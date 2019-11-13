using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator.Helpers
{
    /// <summary>
    /// Helper for common functions
    /// </summary>
    internal static class CommonHelper
    {
        public static void CheckGreaterThanZero(double argument, string description = "Argument")
        {
            if (argument <= 0) throw new ArgumentOutOfRangeException(
                $"{description} must be greater than 0");
        }
    }
}
