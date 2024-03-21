using System.Drawing;

namespace Figures;

public class Line : Shape
{
    public Point StartPoint { get; set; }
    public Point EndPoint { get; set; }

    public override void Draw(Graphics? graphics, float width, Color color)
    {
        graphics?.DrawLine(new Pen(color, width), StartPoint, EndPoint);
    }

    public override void DrawDynamic(ref Graphics? graphics, Point startPoint, Point endPoint, float width, Color currentColor)
    {
        graphics.DrawLine(new Pen(currentColor, width), startPoint, endPoint);
    }
}