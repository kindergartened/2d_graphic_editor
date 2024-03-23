using System.Drawing;

namespace Figures;

public class Square : Rectangle
{
    public int SideLength { get; set; }

    /// <summary>
    /// Метод использует свойство SideLength 
    /// для определения размера прямоугольника 
    /// и рисует его на графическом контексте.
    /// </summary>
    /// <param name="graphics">графика</param>
    /// <param name="width">ширина</param>
    /// <param name="color">цвет</param>
    public override void Draw(Graphics? graphics, float width, Color color)
    {
        int halfSide = SideLength / 2;
        graphics?.DrawRectangle(new Pen(color, width), Center.X - halfSide, Center.Y - halfSide, SideLength, SideLength);
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
    public override void DrawDynamic(ref Graphics? graphics, Point startPoint, Point endPoint, float width, Color currentColor)
    {
        int sideLength = Math.Max(Math.Abs(startPoint.X - endPoint.X), Math.Abs(startPoint.Y - endPoint.Y));
        graphics?.DrawRectangle(new Pen(currentColor, width), Math.Min(startPoint.X, endPoint.X),
            Math.Min(startPoint.Y, endPoint.Y), sideLength, sideLength);
    }
}