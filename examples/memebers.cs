// an example class with all possible members
/*
    // Create an instance of ExampleClass
    ExampleClass exampleInstance = new ExampleClass(50);

    // Use various members of the class
    Console.WriteLine("Property Value: " + exampleInstance.PropertyValue);
    exampleInstance.PerformAction();

    // Use the indexer
    exampleInstance[3] = 10;
    Console.WriteLine("Indexed Value: " + exampleInstance[3]);
    Console.WriteLine("PropertyValue: " + exampleInstance.PropertyValue);

    // Use the property with a private setter
    exampleInstance.Property = 100;
    Console.WriteLine("Property: " + exampleInstance.Property);
*/
public class ExampleClass
{
    // a property
    public int PropertyValue { get; set; }

    // a constructor
    public ExampleClass(int value)
    {
        PropertyValue = value;
    }

    // a method
    public void PerformAction()
    {
        Console.WriteLine("Action performed.");
    }

    // an indexer
    // exampleInstance[3] = 10;
    // this will set the PropertyValue to 10 (value)
    // and return 6 (index * 2)
    public int this[int index]
    {
        get { return index * 2; }
        set { PropertyValue = value; }
    }

    // a property
    public int Property { get; set; }

    // an operator
    public static ExampleClass operator +(ExampleClass a, ExampleClass b)
    {
        return new ExampleClass(a.PropertyValue + b.PropertyValue);
    }

    // a finalizer
    // finalizer is called when the object is garbage collected
    ~ExampleClass()
    {
        Console.WriteLine("Finalizer called.");
    }
}
