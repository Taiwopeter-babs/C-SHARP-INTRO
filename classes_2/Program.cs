using AllStructsAndInterfaces;
public class Point
{
    private readonly List<double> multiples = new List<double> { 2.0, 3.0, 4.0 };
    public int X { get; }
    public int Y { get; }

    private int retValue;

    public int Multiple
    {
        get { return retValue; }
        set { retValue = value * X * Y; }
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public List<double> getMultiplesOfX()
    {
        List<double> result = new List<double>(3);
        foreach (var multiple in multiples)
        {
            result.Add(X * multiple);
        }
        return result;
    }
}

public class Point3D : Point
{
    public int Z { get; }

    public Point3D(int x, int y, int z) : base(x, y)
    {
        Z = z;
    }
}

public class Pair<TFirst, TSecond>
{
    public TFirst First { get; }
    public TSecond Second { get; }

    public Pair(TFirst first, TSecond second)
    {
        First = first;
        Second = second;
    }
}

public class MainClass
{
    static void Main(string[] args)
    {
        var p1 = new Point(108, 20);
        p1.Multiple = 2;
        Console.WriteLine($"{p1.X} {p1.Y} {p1.Multiple}");
        // Console.WriteLine(p1.getMultiplesOfX());
        var result = p1.getMultiplesOfX();
        foreach (var multiple in result)
        {
            Console.WriteLine($"{multiple}");
        }
        var p2 = new Point3D(3, 5, 23);
        Console.WriteLine($"{p2.X} {p2.Y} {p2.Z}");

        var pair = new Pair<string, int>("My name is Taiwo", 23);
        Console.WriteLine($"{pair.First} {pair.Second}");

        PointStruct pointStruct = new PointStruct();
        Console.WriteLine($"{pointStruct.A}, {pointStruct.B}");
        Console.WriteLine($"{pointStruct.MyCoordinates()}");

    }

}