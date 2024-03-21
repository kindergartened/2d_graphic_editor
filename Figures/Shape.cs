using System.Drawing;

namespace Figures;

public abstract class Shape
{
    public Point Center { get; set; }
    public Color FillColor { get; set; }

    public abstract void Draw(Graphics? graphics, float width, Color color);
    public abstract void DrawDynamic(ref Graphics? graphics, Point startPoint, Point endPoint, float width, Color currentColor);
}