using System.Drawing;

namespace Figures;

public class Ellipse : Shape
{
    public int HorizontalRadius { get; set; }
    public int VerticalRadius { get; set; }

    public override void Draw(Graphics? graphics, float width, Color color)
    {
        graphics?.DrawEllipse(new Pen(color, width), Center.X - HorizontalRadius, Center.Y - VerticalRadius,
            2 * HorizontalRadius, 2 * VerticalRadius);
    }

    public override void DrawDynamic(ref Graphics? graphics, Point startPoint, Point endPoint, float width, Color currentColor)
    {
        int horizontalRadius = Math.Abs(startPoint.X - endPoint.X) / 2;
        int verticalRadius = Math.Abs(startPoint.Y - endPoint.Y) / 2;
        graphics.DrawEllipse(new Pen(currentColor, width), Math.Min(startPoint.X, endPoint.X),
            Math.Min(startPoint.Y, endPoint.Y), 2 * horizontalRadius, 2 * verticalRadius);
    }
}