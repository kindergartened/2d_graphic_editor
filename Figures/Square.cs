using System.Drawing;

namespace Figures;

public class Square : Shape
{
    public int SideLength { get; set; }

    public override void Draw(Graphics? graphics, float width, Color color)
    {
        int halfSide = SideLength / 2;
        graphics.DrawRectangle(new Pen(color, width), Center.X - halfSide, Center.Y - halfSide, SideLength, SideLength);
    }
}