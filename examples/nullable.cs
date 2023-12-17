/*
The compiler provides warnings when nullable references are dereferenced without first checking their value against null.
The compiler also provides warnings when non-nullable references are assigned a value that may be null


    var p = new ContainsNullable();
    int? number = p.NumberMaybeNull;
    string? str = default;
    string anotherStr = "";
    Console.WriteLine(str?.Equals(anotherStr)); // false, because str is null


The ?? is called the null-coalescing operator in C#.
It is used to provide a default value for a nullable type or expression when the value is null. Here's how it works:

result = expression1 ?? expression2;

If expression1 is not null, then result takes the value of expression1. If expression1 is null, then result takes the value of expression2.

ex: Console.WriteLine(null ?? "Hello, World!");
*/

class ContainsNullable
{
    public int? NumberMaybeNull { get; set; }
    public string? StringMaybeNull { get; set; }
    public string NotNull { get; set; } = "";
}
