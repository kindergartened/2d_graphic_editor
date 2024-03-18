using System.Drawing;

namespace Figures;

public class ArrayPoints
{
    private int index = 0;
    private Point[] points;

    /// <summary>
    /// Конструктор класса ArrayPoints, который инициализирует массив точек размером size. 
    /// Если size меньше или равен 0, то размер массива устанавливается равным 2.
    /// </summary>
    /// <param name="size">Изначальный размер точки</param>
    public ArrayPoints(int size)
    {
        if (size <= 0) size = 2;

        points = new Point[size];
    }

    /// <summary>
    /// Метод, который устанавливает точку с координатами (x, y) в массив точек. 
    /// Если индекс достигает размера массива, он сбрасывается до 0. 
    /// Индекс увеличивается на 1 после установки точки.
    /// </summary>
    /// <param name="x">точка координат</param>
    /// <param name="y">точка координат</param>
    public void SetPoint(int x, int y)
    {
        if (index >= points.Length) index = 0;

        points[index] = new Point(x, y);
        index++;
    }

    /// <summary>
    /// Метод, который сбрасывает индекс до 0, возвращая массив точек к его начальному состоянию.
    /// </summary>
    public void ResetPoints() { index = 0; }

    /// <summary>
    /// Метод, который возвращает текущее количество точек в массиве.
    /// </summary>
    /// <returns></returns>
    public int GetPointsCount() => index;

    /// <summary>
    /// Метод, который возвращает массив точек.
    /// </summary>
    /// <returns></returns>
    public Point[] GetPoints() => points;
}
