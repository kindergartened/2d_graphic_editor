using System.Drawing;

namespace Figures;

public class Triangle : Shape
{
    public int SideLength { get; set; }

    public override void Draw(Graphics? graphics)
    {
        Point point1 = new Point(Center.X, Center.Y - SideLength / 2);
        Point point2 = new Point(Center.X + SideLength / 2, Center.Y + SideLength / 2);
        Point point3 = new Point(Center.X - SideLength / 2, Center.Y + SideLength / 2);
        Point[] points = { point1, point2, point3 };
        graphics.DrawPolygon(new Pen(Color.Black), points);
    }
}