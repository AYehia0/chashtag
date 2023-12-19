public class Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y) => (X, Y) = (x, y);
}

// Generates n points with random x,y values using Random()
// var points = new PointFactory(3);
// foreach (var point in points.createPoints())
// {
//     Console.WriteLine(point.X);
// }
public class PointFactory(int pointsNum)
{
    public IEnumerable<Point> createPoints()
    {
        var generator = new Random();
        for (int i = 0; i < pointsNum; i++)
        {
            var p = new Point(generator.Next(), generator.Next());
            yield return p;
        }
    }
}
