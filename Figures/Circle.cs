using System.Drawing;

namespace Figures;

public class Circle : Ellipse
{
    public int Radius { get; set; }

    /// <summary>
    /// Метод использует свойство Radius для определения 
    /// размера эллипса и рисует его на графическом контексте.
    /// </summary>
    /// <param name="graphics">графика</param>
    /// <param name="width">ширина</param>
    /// <param name="color">цвет</param>
    public override void Draw(Graphics? graphics, float width, Color color) => graphics?.DrawEllipse(new Pen(color, width), Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);

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
        int radius = (int)Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2));
        graphics.DrawEllipse(new Pen(currentColor, width),
                             startPoint.X - radius,
                             startPoint.Y - radius,
                             2 * radius,
                             2 * radius);
    }
}