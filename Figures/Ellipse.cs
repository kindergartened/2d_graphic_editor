using System.Drawing;

namespace Figures;

public class Ellipse : Shape
{
    public int HorizontalRadius { get; set; }
    public int VerticalRadius { get; set; }

    public override void Draw(Graphics? graphics)
    {
        graphics.DrawEllipse(new Pen(Color.Black), Center.X - HorizontalRadius, Center.Y - VerticalRadius,
            2 * HorizontalRadius, 2 * VerticalRadius);
    }
}