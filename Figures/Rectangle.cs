using System.Drawing;

namespace Figures;

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override void Draw(Graphics graphics)
    {
        graphics.DrawRectangle(new Pen(Color.Black), Center.X - Width / 2, Center.Y - Height / 2, Width, Height);
    }
}