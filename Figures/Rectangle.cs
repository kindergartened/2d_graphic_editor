using System.Drawing;

namespace Figures;

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override void Draw(Graphics? graphics, float width, Color color)
    {
        graphics?.DrawRectangle(new Pen(color, width), Center.X - Width / 2, Center.Y - Height / 2, Width, Height);
    }

    public override void DrawDynamic(ref Graphics? graphics, Point startPoint, Point endPoint, float currWidth, Color currentColor)
    {
        int width = Math.Abs(startPoint.X - endPoint.X);
        int height = Math.Abs(startPoint.Y - endPoint.Y);
        graphics.DrawRectangle(new Pen(currentColor, currWidth), Math.Min(startPoint.X, endPoint.X),
            Math.Min(startPoint.Y, endPoint.Y), width, height);
    }
}