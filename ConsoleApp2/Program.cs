using ConsoleApp2;

static double DistanceBetweenPoints(Point a, Point b)
{
    var distance = Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));
    return distance;
}

var distance = DistanceBetweenPoints(new Point(-10.2, 12.5), new Point(0.3, 14.7));
Console.WriteLine(distance);