public class Program
{
    private static void Main()
    {
        decimal km = 1m;
        decimal miles = 0.621371m;

        Neuron km_miles = new Neuron();
        Neuron.Example km_miles_example = new Neuron.Example(km, miles);

        decimal result = km_miles.AutomaticConvertData(km_miles_example, 2.1m);

        Console.WriteLine($"result: {result} | weight: {km_miles.weight}");
    }
}