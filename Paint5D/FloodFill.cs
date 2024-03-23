using System.Drawing.Imaging;

namespace Paint5D;

public static class FloodFill
{
    /// <summary>
    /// метод используется для заполнения области вокруг точки нажатия текущим цветом.
    /// </summary>
    /// <param name="bitmap">изображение, на котором будет производиться заполнение</param>
    /// <param name="startPoint">это точка, вокруг которой будет производиться заполнение</param>
    /// <param name="targetColor">это цвет, который будет заменен на fillColor</param>
    /// <param name="fillColor">цвет, которым будет заполнена область вокруг startPoint</param>
    public static void Fill(Bitmap bitmap, Point startPoint, Color targetColor, Color fillColor)
    {
        int width = bitmap.Width;
        int height = bitmap.Height;

        // Создаем массив для отслеживания посещенных пикселей
        bool[,] visited = new bool[width, height];

        // Создаем очередь для хранения координат заполняемых пикселей
        Queue<Point> queue = new Queue<Point>();
        queue.Enqueue(startPoint);

        // Получаем целочисленные представления цветов
        int targetArgb = targetColor.ToArgb();

        // Пока очередь не пуста
        while (queue.Count > 0)
        {
            // Извлекаем точку из очереди
            Point point = queue.Dequeue();
            int x = point.X;
            int y = point.Y;

            // Проверяем, что координаты находятся в пределах изображения
            if (x >= 0 && x < width && y >= 0 && y < height)
            {
                // Проверяем, был ли уже посещен данный пиксель
                if (!visited[x, y])
                {
                    // Помечаем пиксель как посещенный
                    visited[x, y] = true;

                    // Проверяем, является ли цвет пикселя целевым
                    if (bitmap.GetPixel(x, y).ToArgb() == targetArgb)
                    {
                        // Заливаем пиксель указанным цветом
                        bitmap.SetPixel(x, y, fillColor);

                        // Добавляем соседние пиксели в очередь для последующей проверки
                        queue.Enqueue(new Point(x + 1, y));
                        queue.Enqueue(new Point(x - 1, y));
                        queue.Enqueue(new Point(x, y + 1));
                        queue.Enqueue(new Point(x, y - 1));
                    }
                }
            }
        }
    }
}