using System.Drawing;

namespace Figures;

public class Line : Shape
{
    public Point EndPoint { get; set; }

    public override void Draw(Graphics graphics)
    {
        graphics.DrawLine(new Pen(Color.Black), Center, EndPoint);
    }
}