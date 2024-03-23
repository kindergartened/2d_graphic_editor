using System.Drawing;

namespace Figures;

public class Ellipse : Shape
{
    public int HorizontalRadius { get; set; }
    public int VerticalRadius { get; set; }

    /// <summary>
    /// Метод использует свойства HorizontalRadius и VerticalRadius 
    /// для определения размера эллипса и рисует его на графическом контексте.
    /// </summary>
    /// <param name="graphics">графика</param>
    /// <param name="width">ширина</param>
    /// <param name="color">цвет</param>
    public override void Draw(Graphics? graphics, float width, Color color)
    {
        graphics?.DrawEllipse(new Pen(color, width), Center.X - HorizontalRadius, Center.Y - VerticalRadius,
            2 * HorizontalRadius, 2 * VerticalRadius);
    }

    /// <summary>
    /// Метод использует координаты двух точек (startPoint и endPoint) 
    /// для определения центра эллипса и его размера. 
    /// Затем он рисует эллипс на графическом контексте.
    /// </summary>
    /// <param name="graphics">графика</param>
    /// <param name="startPoint">начальная точка</param>
    /// <param name="endPoint">конечная точка</param>
    /// <param name="width">ширина</param>
    /// <param name="currentColor">цвет</param>
    public override void DrawDynamic(ref Graphics? graphics, Point startPoint, Point endPoint, float width, Color currentColor)
    {
        int horizontalRadius = Math.Abs(startPoint.X - endPoint.X) / 2;
        int verticalRadius = Math.Abs(startPoint.Y - endPoint.Y) / 2;
        graphics.DrawEllipse(new Pen(currentColor, width),
                             Math.Min(startPoint.X, endPoint.X),
                             Math.Min(startPoint.Y, endPoint.Y),
                             2 * horizontalRadius,
                             2 * verticalRadius);
    }
}