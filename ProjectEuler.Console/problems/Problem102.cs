
public class Problem102
{

    public List<Triangle> Triangles { get; set; }

    public Problem102()
    {
        // Read the text file
        var text = File.ReadAllLines(@"data/problem102data.txt");

        var lines = text.Select(line => line.Split(',').Select(int.Parse).ToArray()).ToList();
        Triangles = new List<Triangle>();
        foreach (var line in lines)
        {
            if (line.Length == 6)
            {
                var triangle = new Triangle(
                    new Point(line[0], line[1]),
                    new Point(line[2], line[3]),
                    new Point(line[4], line[5])
                );
                Triangles.Add(triangle);
            }
        }

    }

    public long Run()
    {
        return Triangles.Count(t => t.ContainsOrigin());
    }
}

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool IsOrigin()
    {
        return X == 0 && Y == 0;
    }
}

public class Triangle
{
    public Point A { get; set; }
    public Point B { get; set; }
    public Point C { get; set; }

    public Triangle(Point x, Point y, Point z)
    {
        A = x;
        B = y;
        C = z;
    }

    public bool ContainsOrigin()
    {
        double cross1 = A.X * B.Y - A.Y * B.X;
        double cross2 = B.X * C.Y - B.Y * C.X;
        double cross3 = C.X * A.Y - C.Y * A.X;

        return (cross1 >= 0 && cross2 >= 0 && cross3 >= 0) ||
               (cross1 <= 0 && cross2 <= 0 && cross3 <= 0);
    }

    public bool NotContainsOrigin()
    {
        return !ContainsOrigin();
    }

    public override string ToString()
    {
        return $"Triangle: A({A.X}, {A.Y}), B({B.X}, {B.Y}), C({C.X}, {C.Y})";
    }
}

