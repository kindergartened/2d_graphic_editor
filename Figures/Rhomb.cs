using System.Drawing;

namespace Figures;

public class Rhomb : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    /// <summary>
    /// Метод использует свойства Width и Height 
    /// для определения размера многоугольника и 
    /// рисует его на графическом контексте.
    /// </summary>
    /// <param name="graphics">графика</param>
    /// <param name="width">ширина</param>
    /// <param name="color">цвет</param>
    public override void Draw(Graphics? graphics, float width, Color color)
    {
        graphics?.DrawPolygon(new Pen(color, width), CalcPoints());
    }

    /// <summary>
    /// Метод DrawDynamic использует координаты двух точек (startPoint и endPoint) 
    /// для определения размера многоугольника и рисует его на графическом контексте.
    /// </summary>
    /// <param name="graphics">графика</param>
    /// <param name="startPoint">начальная точка</param>
    /// <param name="endPoint">конечная точка</param>
    /// <param name="width">ширина</param>
    /// <param name="currentColor">цвет</param>
    public override void DrawDynamic(ref Graphics? graphics, Point startPoint, Point endPoint, float currentWidth, Color currentColor)
    {
        Width = Math.Abs(startPoint.X - endPoint.X);
        Height = Math.Abs(startPoint.Y - endPoint.Y);
        graphics.DrawPolygon(new Pen(currentColor, currentWidth), CalcPoints());
    }

    /// <summary>
    /// Метод создает массив точек, которые определяют форму многоугольника.
    /// </summary>
    /// <returns>возвращает массив точек</returns>
    private Point[] CalcPoints()
    {
        Point point1 = new Point(Center.X, Center.Y - Height / 2);
        Point point2 = new Point(Center.X + Width / 2, Center.Y);
        Point point3 = new Point(Center.X, Center.Y + Height / 2);
        Point point4 = new Point(Center.X - Width / 2, Center.Y);
        return new [] { point1, point2, point3, point4 };
    }
}