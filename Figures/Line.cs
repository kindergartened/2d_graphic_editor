using System.Drawing;

namespace Figures;

public class Line : Shape
{
    public Point StartPoint { get; set; }
    public Point EndPoint { get; set; }

    /// <summary>
    /// Метод использует свойства StartPoint и EndPoint 
    /// для определения начала и конца линии и рисует ее на 
    /// графическом контексте.
    /// </summary>
    /// <param name="graphics">графика</param>
    /// <param name="width">ширина</param>
    /// <param name="color">цвет</param>
    public override void Draw(Graphics? graphics, float width, Color color)
    {
        graphics?.DrawLine(new Pen(color, width), StartPoint, EndPoint);
    }

    /// <summary>
    /// Метод использует координаты двух точек (startPoint и endPoint) 
    /// для определения начала и конца линии и рисует ее на графическом контексте.
    /// </summary>
    /// <param name="graphics">графика</param>
    /// <param name="startPoint">начальная точка</param>
    /// <param name="endPoint">конечная точка</param>
    /// <param name="width">ширина</param>
    /// <param name="currentColor">цвет</param>
    public override void DrawDynamic(ref Graphics? graphics, Point startPoint, Point endPoint, float width, Color currentColor)
    {
        graphics.DrawLine(new Pen(currentColor, width), startPoint, endPoint);
    }
}