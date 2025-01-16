using StaticExercise;


static void Main(string[] args)
{
    var celsius = TempConverter.FahrenheitToCelsius(68);
    var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
    
    Console.WriteLine("After conversion:");
    Console.WriteLine($"Celsius: {celsius}");
    Console.WriteLine($"Fahrenheit: {fahrenheit}");
}
Console.Write($"Fahrenheit -> Celsius: {TempConverter.FahrenheitToCelsius(32)} ");
Console.WriteLine();

Console.Write($"Celsius -> Fahrenheit : {TempConverter.CelsiusToFahrenheit(0)} ");
Console.WriteLine();