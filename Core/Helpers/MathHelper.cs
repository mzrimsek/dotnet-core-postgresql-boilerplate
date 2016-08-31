using System;

namespace Core.Helpers
{
    public static class MathHelper
    {
        public static double AddNumbers(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double DivideNumbers(double numerator, double denominator)
        {
            if(numerator == 0 || denominator == 0) return 0;
            return numerator/denominator;
        }
    }
}