using System.Drawing;

namespace Figures;

public class Square : Shape
{
    public int SideLength { get; set; }

    public override void Draw(Graphics? graphics, float width, Color color)
    {
        int halfSide = SideLength / 2;
        graphics?.DrawRectangle(new Pen(color, width), Center.X - halfSide, Center.Y - halfSide, SideLength, SideLength);
    }

    public override void DrawDynamic(ref Graphics? graphics, Point startPoint, Point endPoint, float width, Color currentColor)
    {
        int sideLength = Math.Max(Math.Abs(startPoint.X - endPoint.X), Math.Abs(startPoint.Y - endPoint.Y));
        graphics?.DrawRectangle(new Pen(currentColor, width), Math.Min(startPoint.X, endPoint.X),
            Math.Min(startPoint.Y, endPoint.Y), sideLength, sideLength);
    }
}