namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fahrenheit to Celsius");
            Console.WriteLine(TempConverter.FahrenheitToCelsius(32));
            Console.WriteLine();
            Console.WriteLine("Celsius to Fahrenheit");
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(0));
        }
    }
}
