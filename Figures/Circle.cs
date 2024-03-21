using System.Drawing;

namespace Figures;

public class Circle : Ellipse
{
    public int Radius { get; set; }

    public override void Draw(Graphics? graphics, float width, Color color)
    {
        graphics?.DrawEllipse(new Pen(color, width), Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
    }

    public override void DrawDynamic(ref Graphics? graphics, Point startPoint, Point endPoint, float width, Color currentColor)
    {
        int radius = (int)Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2));
        graphics.DrawEllipse(new Pen(currentColor, width), startPoint.X - radius, startPoint.Y - radius, 2 * radius,
            2 * radius);
    }
}