using System.Drawing;

namespace Figures;

public class Line : Shape
{
    public Point StartPoint { get; set; }
    public Point EndPoint { get; set; }

    public override void Draw(Graphics? graphics, float width, Color color)
    {
        graphics.DrawLine(new Pen(color, width), StartPoint, EndPoint);
    }
}