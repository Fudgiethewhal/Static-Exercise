using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StaticExercise;

internal static class TempConverter
{
    public static double FarenheitToCelsius(double fTemp)
    {
        // C = (F - 32) * 5 / 9;
        return (fTemp - 32) * 5 / 9;
    }

    public static double CelsiusToFarenheit(double cTemp)
    {
        // F = (C*9)/5 + 32;
        return (cTemp * 9) / 5 + 32;
    }
}