using System.Drawing;

namespace Figures;

public abstract class Shape
{
    public Point Center { get; set; }
    public Color FillColor { get; set; }

    public abstract void Draw(Graphics graphics);
}