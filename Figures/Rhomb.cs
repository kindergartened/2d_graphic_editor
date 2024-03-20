using System.Drawing;

namespace Figures;

public class Rhomb : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override void Draw(Graphics? graphics)
    {
        Point point1 = new Point(Center.X, Center.Y - Height / 2);
        Point point2 = new Point(Center.X + Width / 2, Center.Y);
        Point point3 = new Point(Center.X, Center.Y + Height / 2);
        Point point4 = new Point(Center.X - Width / 2, Center.Y);
        Point[] points = { point1, point2, point3, point4 };
        graphics.DrawPolygon(new Pen(Color.Black), points);
    }
}