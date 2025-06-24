public class Neuron
{
    public decimal weight { get; private set; } = 0.000000001m;
    private decimal smoothing = 0.000000001m;

    public decimal ProcessInputData(decimal input)
    {
        decimal output = input * weight;
        return output;
    }

    public decimal AutomaticConvertData(Example example, decimal input)
    {
        Train(example.data1, example.data2, 1000000000);
        return ProcessInputData(input);
    }

    public void Train(decimal input, decimal result, int maxIterations)
    {
        for (int i = 0; i < maxIterations; i++)
        {
            if (ProcessInputData(input) == result)
                break;

            weight += smoothing;
        }
    }

    public struct Example
    {
        public decimal data1 { get; private set; }
        public decimal data2 { get; private set; }

        public Example(decimal data1, decimal data2)
        {
            this.data1 = data1;
            this.data2 = data2;
        }
    }
}