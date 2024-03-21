using System.Drawing;

namespace Figures;

public class Triangle : Shape
{
    public int[] SideLengths = new int[3];

    public override void Draw(Graphics? graphics, float width, Color color)
    {
        Point point1 = new Point(Center.X, Center.Y - SideLengths[0] / 2);
        Point point2 = new Point(Center.X + SideLengths[1] / 2, Center.Y + SideLengths[1] / 2);
        Point point3 = new Point(Center.X - SideLengths[2] / 2, Center.Y + SideLengths[2] / 2);
        Point[] points = { point1, point2, point3 };
        graphics.DrawPolygon(new Pen(color, width), points);
    }
}