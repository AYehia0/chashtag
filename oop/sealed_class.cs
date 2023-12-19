/*
One of the principles of OOP is inheritance, but sometimes you may need to restrict
inheritance in your code for the sake of your application's architecture. C# provides a
keyword called sealed. If this keyword is placed before a class's signature, the class is
considered a sealed class.

If a class is sealed, that particular class can't be inherited by other
classes. If any class tries to inherit a sealed class, the compiler will throw an error.

PS: Structs can also be sealed, and in that case, no class can inherit that struct.

*/

// this class can't be inherited
sealed class SealedClass
{
    public void Method1()
    {
        Console.WriteLine("Method1");
    }
}
