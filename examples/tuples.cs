/*
    Tuples are a new feature in C# 7.0. They are a lightweight data structure that
    contain multiple fields to represent the data members. Tuples are of value types.

    var t = new Tuples();
    var tuple = t.CreateTuple(1, 2);
    Console.WriteLine($"Tuple: {tuple.Item1}, {tuple.Item2}");


    Tuples are useful when you want to return multiple values from a method without defining a type to encapsulate them.
    
    you can also use tuples like this:
    (int, int) tuple = (1, 2); // tuple.Item1 == 1, tuple.Item2 == 2
    (double Sum, int Count) t2 = (4.5, 3); // t2.Sum == 4.5, t2.Count == 3

*/

public class Tuples
{
    public Tuple<int, int> CreateTuple(int x, int y)
    {
        return Tuple.Create(x, y);
    }
}
