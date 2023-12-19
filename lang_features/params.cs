// you can pass ref parameters to methods using ref keyword if the parameter isn't pointer like int, float, double, etc.
/*
    int x = 1,
        y = 2;
    Swapper.SwapRef(ref x, ref y);
    Console.WriteLine($"x = {x}, y = {y}");
*/
class Params
{
    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // out keyword is like ref but it doesn't need to be initialized before passing to the method
    // It's similar to a reference parameter, except that it doesn't require that you explicitly assign a value to the caller-provided argument
    public static void Divide(int a, int b, out int result, out int remainder)
    {
        result = a / b;
        remainder = a % b;
    }

    // parameter array is like params in C++
    // A parameter array permits a variable number of arguments to be passed to a method. A parameter array is declared with the params modifier. Only the last parameter of a method
    /*
            Params.Sum(out int result, 1, 2, 3, 4, 5);
            Console.WriteLine($"Sum of 1, 2, 3, 4, 5 is {result}");
            Params.Println(1, 2, 3, 4, 5, "Hello", "World", 1.0f, 2.0f, 3.0f);
    */
    public static void Sum(out int result, params int[] numbers)
    {
        result = 0;
        foreach (int number in numbers)
        {
            result += number;
        }
    }

    // a Console.WriteLine method using params
    public static void Println(string fmt, params object[] objects)
    {
        Console.WriteLine(fmt, objects);
    }
}
