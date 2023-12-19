// C# and .NET provides many collection types, Generic types are listed in the System.Collections.Generic namespace.
// System.Span<T> is used to access a contiguous region of arbitrary memory, similar to an array. (Stack)
// System.Memory<T> is used to represent a contiguous region of arbitrary memory, similar to an array.(Managed Heap)
// for iteration. You use the System.Collections.Generic.IEnumerable<T> interface.
// This unifying principle means that any of the collection types can be used with LINQ queries or other algorithms.
// You write methods using IEnumerable<T> and those algorithms work with any collection.

public class DataStuctures
{
    // arrays
    int[] arraySingleDim = new int[10];
    int[,] arrayMultiDim = new int[10, 10];
    int[,,] arrayMultiDim3D = new int[10, 10, 10];

    // array contains 1 to 9
    int[] a1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int[] a2 = [1, 2, 3];

    // lists
    List<int> list = new List<int>();

    // dictionaries
    Dictionary<string, int> dict = new Dictionary<string, int>();

    // hashsets
    HashSet<int> hashset = new HashSet<int>();

    // queues
    Queue<int> queue = new Queue<int>();

    // stacks
    Stack<int> stack = new Stack<int>();

    // linked lists
    LinkedList<int> linkedList = new LinkedList<int>();

    // sets
    SortedSet<int> sortedSet = new SortedSet<int>();

    // looping over array
    public void LoopingOverArray()
    {
        for (int i = 0; i < arraySingleDim.Length; i++)
        {
            arraySingleDim[i] = i;
        }

        foreach (int a in a1)
        {
            Console.WriteLine(a);
        }
    }

    // looping over list
    public void LoopingOverList()
    {
        for (int i = 0; i < 10; i++)
        {
            list.Append(1);
        }

        foreach (int a in list)
        {
            Console.WriteLine(a);
        }
    }
}
