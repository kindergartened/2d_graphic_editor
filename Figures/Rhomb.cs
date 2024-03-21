using System.Drawing;

namespace Figures;

public class Rhomb : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override void Draw(Graphics? graphics, float width, Color color)
    {
        graphics?.DrawPolygon(new Pen(color, width), CalcPoints());
    }

    public override void DrawDynamic(ref Graphics? graphics, Point startPoint, Point endPoint, float currentWidth, Color currentColor)
    {
        Width = Math.Abs(startPoint.X - endPoint.X);
        Height = Math.Abs(startPoint.Y - endPoint.Y);
        graphics.DrawPolygon(new Pen(currentColor, currentWidth), CalcPoints());
    }

    private Point[] CalcPoints()
    {
        Point point1 = new Point(Center.X, Center.Y - Height / 2);
        Point point2 = new Point(Center.X + Width / 2, Center.Y);
        Point point3 = new Point(Center.X, Center.Y + Height / 2);
        Point point4 = new Point(Center.X - Width / 2, Center.Y);
        return new [] { point1, point2, point3, point4 };
    }
}