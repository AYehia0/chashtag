delegate double DoubleOp(double x);
delegate T GenericOp<T>(T x);

// a delegate to generic function

/*
    double[] values = new double[] { 1, 2, 3, 4, 5 };
    Multiplier.Apply(values, x => x + 2);

    // print values
    Console.WriteLine("Values:");
    foreach (double value in values)
    {
        Console.WriteLine(value);
    }
*/
class Multiplier
{
    double factor;

    public Multiplier(double factor)
    {
        this.factor = factor;
    }

    public double Multiply(double x)
    {
        return x * factor;
    }

    // apply operation to array of values
    public static void Apply(double[] values, DoubleOp op)
    {
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = op(values[i]);
        }
    }

    // apply function that takes generic type
    /*
        double[] values = new double[] { 1, 2, 3, 4, 5 };
        Multiplier.Apply<double>(values, x => x + 2);
        Console.WriteLine(string.Join(", ", values));
    */
    public static void Apply<T>(T[] values, GenericOp<T> op)
    {
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = op(values[i]);
        }
    }
}
