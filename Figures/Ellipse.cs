using System.Drawing;

namespace Figures;

public class Ellipse : Shape
{
    public int HorizontalRadius { get; set; }
    public int VerticalRadius { get; set; }

    public override void Draw(Graphics? graphics, float width, Color color)
    {
        graphics.DrawEllipse(new Pen(color, width), Center.X - HorizontalRadius, Center.Y - VerticalRadius,
            2 * HorizontalRadius, 2 * VerticalRadius);
    }
}