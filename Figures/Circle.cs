using System.Drawing;

namespace Figures;

public class Circle : Ellipse
{
    public int Radius { get; set; }

    public override void Draw(Graphics? graphics, float width, Color color)
    {
        graphics.DrawEllipse(new Pen(color, width), Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
    }
}