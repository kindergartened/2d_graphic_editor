using System.Drawing;

namespace Figures;

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    /// <summary>
    /// Метод использует свойства Width и Height 
    /// для определения размера прямоугольника и 
    /// рисует его на графическом контексте.
    /// </summary>
    /// <param name="graphics">графика</param>
    /// <param name="width">ширина</param>
    /// <param name="color">цвет</param>
    public override void Draw(Graphics? graphics, float width, Color color)
    {
        graphics?.DrawRectangle(new Pen(color, width), Center.X - Width / 2, Center.Y - Height / 2, Width, Height);
    }

    /// <summary>
    /// Метод DrawDynamic использует координаты двух точек (startPoint и endPoint) 
    /// для определения размера прямоугольника и рисует его на графическом контексте.
    /// </summary>
    /// <param name="graphics">графика</param>
    /// <param name="startPoint">начальная точка</param>
    /// <param name="endPoint">конечная точка</param>
    /// <param name="width">ширина</param>
    /// <param name="currentColor">цвет</param>
    public override void DrawDynamic(ref Graphics? graphics, Point startPoint, Point endPoint, float currWidth, Color currentColor)
    {
        int width = Math.Abs(startPoint.X - endPoint.X);
        int height = Math.Abs(startPoint.Y - endPoint.Y);
        graphics.DrawRectangle(new Pen(currentColor, currWidth), Math.Min(startPoint.X, endPoint.X),
            Math.Min(startPoint.Y, endPoint.Y), width, height);
    }
}