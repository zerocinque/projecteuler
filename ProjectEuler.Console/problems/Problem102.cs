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
                    new Coordinate(line[0], line[1]),
                    new Coordinate(line[2], line[3]),
                    new Coordinate(line[4], line[5])
                );
                Triangles.Add(triangle);
            }
        }
    }

    public long Run()
    {
        return Triangles.Count(t => t.NotContainsOrigin());
    }
}

public class Coordinate
{
    public int X { get; set; }
    public int Y { get; set; }

    public Coordinate(int x, int y)
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
    public Coordinate A { get; set; }
    public Coordinate B { get; set; }
    public Coordinate C { get; set; }

    public Triangle(Coordinate x, Coordinate y, Coordinate z)
    {
        A = x;
        B = y;
        C = z;
    }

    public bool ContainsOrigin()
    {
        var sumX = A.X + B.X + C.X;
        var sumY = A.Y + B.Y + C.Y;
        return (sumX > 0 && sumY < 0) || (sumX < 0 && sumY > 0);
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

