// this is how you inherite a class in C#, the Point class is called the Base class.
// A class doesn't inherit the instance and static constructors, and the finalizer
// base(x,y) calls the constructor of the Base class, so it sets x,y and Z = z; in the constructor body of the Point3D sets z;
public class Point3D : Point
{
    public int Z { get; set; }

    public Point3D(int x, int y, int z)
        : base(x, y)
    {
        Z = z;
    }
}
