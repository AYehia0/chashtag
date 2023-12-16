// define a class which takes 2 pairs of any type and returns them with getters.
// var pair = new Pair<int, string>(1, "two");
// int i = pair.First;     //TFirst int
// string s = pair.Second; //TSecond string
public class Pair<T1, T2>
{
    public T1? FirstType { get; }
    public T2? SecondType { get; }

    public Pair(T1 t1, T2 t2) => (FirstType, SecondType) = (t1, t2);
}
