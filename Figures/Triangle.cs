using System.Drawing;

namespace Figures;

public class Triangle : Shape
{
    public int[] SideLengths = new int[3];

    /// <summary>
    /// Метод использует свойства Center и SideLengths 
    /// для определения размера многоугольника 
    /// и рисует его на графическом контексте.
    /// </summary>
    /// <param name="graphics">графика</param>
    /// <param name="width">ширина</param>
    /// <param name="color">цвет</param>
    public override void Draw(Graphics? graphics, float width, Color color)
    {
        graphics?.DrawPolygon(new Pen(color, width), CalcPoints());
    }

    /// <summary>
    /// Метод использует координаты двух точек (startPoint и endPoint) 
    /// для определения размера многоугольника и рисует его на графическом контексте.
    /// </summary>
    /// <param name="graphics">графика</param>
    /// <param name="startPoint">начальная точка</param>
    /// <param name="endPoint">конечная точка</param>
    /// <param name="width">ширина</param>
    /// <param name="currentColor">цвет</param>
    public override void DrawDynamic(ref Graphics? graphics, Point startPoint, Point endPoint, float width, Color currentColor)
    {
        SideLengths[0] = (int)Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2));
        SideLengths[1] = (int)Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(startPoint.Y - endPoint.Y, 2));
        SideLengths[2] = (int)Math.Sqrt(Math.Pow(startPoint.X - endPoint.X, 2) + Math.Pow(startPoint.Y - endPoint.Y, 2));
        graphics.DrawPolygon(new Pen(currentColor, width), CalcPoints());
    }

    /// <summary>
    /// Метод создает массив точек, которые определяют форму многоугольника.
    /// </summary>
    /// <returns>возвращает массив точек</returns>
    private Point[] CalcPoints()
    {
        Point point1 = new Point(Center.X, Center.Y - SideLengths[0] / 2);
        Point point2 = new Point(Center.X + SideLengths[1] / 2, Center.Y + SideLengths[1] / 2);
        Point point3 = new Point(Center.X - SideLengths[2] / 2, Center.Y + SideLengths[2] / 2);
        return new[] { point1, point2, point3 };
    }
}