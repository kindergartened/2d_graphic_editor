using System.Drawing;

namespace Figures;

public class Circle : Shape
{
    public int Radius { get; set; }

    public override void Draw(Graphics graphics)
    {
        graphics.DrawEllipse(new Pen(Color.Black), Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
    }
}