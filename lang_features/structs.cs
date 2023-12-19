/*
 *By contrast, struct types are simpler types whose primary purpose is to store data values.
 *Structs can't declare a base type; they implicitly derive from System.ValueType. You can't derive other struct types from a struct type.
 *They're implicitly sealed.
*/

interface IPoint
{
    void PrintPoint(int x, int y);
}

// Structs can implement interfaces
public struct SPoint : IPoint
{
    public int x;
    public int y;

    public SPoint(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    // implement the interface member IPoint.PrintPoint:
    public void PrintPoint(int x, int y)
    {
        Console.WriteLine("Point: {0},{1}", x, y);
    }
}
