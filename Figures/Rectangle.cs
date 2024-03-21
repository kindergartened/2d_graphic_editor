using System.Drawing;

namespace Figures;

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override void Draw(Graphics? graphics, float width, Color color)
    {
        graphics.DrawRectangle(new Pen(color, width), Center.X - Width / 2, Center.Y - Height / 2, Width, Height);
    }
}