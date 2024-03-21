using Figures;
using Rectangle = System.Drawing.Rectangle;

namespace Paint5D;

enum ChosenToolType
{
    Brush,
    Erase,
    Filling,
    Pipette
}

public partial class Form1 : Form
{
    private bool _isMouse;
    private readonly ArrayPoints _arrayPoints = new(2);
    private Bitmap _map = new(100, 100);
    private Graphics? _graphics;
    private readonly Pen _pen = new(Color.Black, 3f);
    private readonly Pen _erase = new(Color.White, 12f);
    private ChosenToolType _choosedTool;
    private Shape? _currentShape; // добавляем переменную для текущей выбранной фигуры
    private Point _startPoint;
    private Point _endPoint;
    private Color _currentColor = Color.Black;
    private float _currentWidth = 3f;
    private ChangesHistory _history = new();

    private void SetBitMapSize()
    {
        Rectangle screenBounds = Screen.PrimaryScreen.Bounds; //определяет разрешение пользователя
        _map = new Bitmap(screenBounds.Width, screenBounds.Height);
        _graphics = Graphics.FromImage(_map);
        _pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
        _pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        _history.AddToHistory(new Bitmap(_map));
    }

    public Form1()
    {
        InitializeComponent();
        SetBitMapSize();
    }


    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
        _isMouse = true;
        _startPoint = e.Location;
        if (_choosedTool == ChosenToolType.Filling)
        {
            FillArea(e.Location, _currentColor);
            pictureBox1.Invalidate(); // Перерисовываем PictureBox
        }
    }

    private void FillArea(Point startPoint, Color fillColor)
    {
        if (pictureBox1.Image != null)
        {
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            Color targetColor = bitmap.GetPixel(startPoint.X, startPoint.Y);
            FloodFill.Fill(bitmap, startPoint, targetColor, fillColor);
            pictureBox1.Refresh();
        }
    }

    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
        _isMouse = false;
        _endPoint = e.Location;

        // Создаем выбранную фигуру на основе начальной и конечной точек
        if (_currentShape != null)
        {
            _currentShape.Center = new Point((_startPoint.X + _endPoint.X) / 2, (_startPoint.Y + _endPoint.Y) / 2);

            if (_currentShape is Line)
            {
                ((Line)_currentShape).StartPoint = _startPoint;
                ((Line)_currentShape).EndPoint = _endPoint;
            }
            else if (_currentShape is Figures.Rectangle)
            {
                int width = Math.Abs(_startPoint.X - _endPoint.X);
                int height = Math.Abs(_startPoint.Y - _endPoint.Y);
                ((Figures.Rectangle)_currentShape).Width = width;
                ((Figures.Rectangle)_currentShape).Height = height;
            }
            else if (_currentShape is Square)
            {
                int sideLength = Math.Max(Math.Abs(_startPoint.X - _endPoint.X), Math.Abs(_startPoint.Y - _endPoint.Y));
                ((Square)_currentShape).SideLength = sideLength;
            }
            else if (_currentShape is Circle)
            {
                int radius =
                    (int)Math.Sqrt(Math.Pow(_endPoint.X - _startPoint.X, 2) + Math.Pow(_endPoint.Y - _startPoint.Y, 2));
                ((Circle)_currentShape).Radius = radius;
            }
            else if (_currentShape is Ellipse)
            {
                int horizontalRadius = Math.Abs(_startPoint.X - _endPoint.X) / 2;
                int verticalRadius = Math.Abs(_startPoint.Y - _endPoint.Y) / 2;
                ((Ellipse)_currentShape).HorizontalRadius = horizontalRadius;
                ((Ellipse)_currentShape).VerticalRadius = verticalRadius;
            }
            else if (_currentShape is Triangle)
            {
                int side1 = (int)Math.Sqrt(Math.Pow(_endPoint.X - _startPoint.X, 2) + Math.Pow(_endPoint.Y - _startPoint.Y, 2));
                int side2 = (int)Math.Sqrt(Math.Pow(_endPoint.X - _startPoint.X, 2) + Math.Pow(_startPoint.Y - _endPoint.Y, 2));
                int side3 = (int)Math.Sqrt(Math.Pow(_startPoint.X - _endPoint.X, 2) + Math.Pow(_startPoint.Y - _endPoint.Y, 2));
                ((Triangle)_currentShape).SideLengths = new[] { side1, side2, side3 };
            }
            else if (_currentShape is Rhomb)
            {
                int width = Math.Abs(_startPoint.X - _endPoint.X);
                int height = Math.Abs(_startPoint.Y - _endPoint.Y);
                ((Rhomb)_currentShape).Width = width;
                ((Rhomb)_currentShape).Height = height;
            }

            _currentShape.Draw(_graphics, _currentWidth, _currentColor);
            pictureBox1.Image = _map;
            _currentShape = null;
        }
        else
        {
            _arrayPoints.ResetPoints();
        }
        _history.AddToHistory(new Bitmap(_map));
    }

    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
        if (!_isMouse) return;
        if (_currentShape != null)
        {
            // При движении мыши рисуем динамическую фигуру
            _endPoint = e.Location;
            pictureBox1.Invalidate();
        }
        else
        {
            _arrayPoints.SetPoint(e.X, e.Y);
            if (_arrayPoints.GetPointsCount() >= 2)
                if (_choosedTool == ChosenToolType.Brush || _choosedTool == ChosenToolType.Erase)
                {
                    _graphics?.DrawLines(_choosedTool == ChosenToolType.Brush ? _pen : _erase, _arrayPoints.GetPoints());
                    pictureBox1.Image = _map;
                    _arrayPoints.SetPoint(e.X, e.Y);
                }
        }
    }

    //универсальная кнопка цветовой палитры
    private void button3_Click(object sender, EventArgs e)
    {
        _currentColor = ((Button)sender).BackColor;
        _pen.Color = _currentColor;
    }

    private void button5_Click(object sender, EventArgs e) //color dialog
    {
        if (colorDialog1.ShowDialog() == DialogResult.OK)
        {
            _pen.Color = colorDialog1.Color;
            ((Button)sender).BackColor = colorDialog1.Color;
        }
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
        _graphics?.Clear(pictureBox1.BackColor);
        pictureBox1.Image = _map;
    }

    private void trackBar1_ValueChanged(object sender, EventArgs e)
    {
        _pen.Width = trackBar1.Value;
        _currentWidth = trackBar1.Value;
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
        saveFileDialog1.Filter = @"JPG(*.JPG)|*.jpg";

        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            if (pictureBox1 != null)
                pictureBox1.Image.Save(saveFileDialog1.FileName);
    }

    private void button11_Click(object sender, EventArgs e)
    {
        _currentShape = null;
        _choosedTool = ChosenToolType.Erase;
    }

    private void button12_Click(object sender, EventArgs e)
    {
        _currentShape = null;
        _choosedTool = ChosenToolType.Brush;
    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
        _history.Undo(ref pictureBox1, ref _graphics, ref _map);
    }

    private void circle_Click(object sender, EventArgs e)
    {
        _currentShape = new Circle();
    }

    private void square_Click(object sender, EventArgs e)
    {
        _currentShape = new Square();
    }

    private void rectangle_Click(object sender, EventArgs e)
    {
        _currentShape = new Figures.Rectangle();
    }

    private void triangle_Click(object sender, EventArgs e)
    {
        _currentShape = new Triangle();
    }

    private void romb_Click(object sender, EventArgs e)
    {
        _currentShape = new Rhomb();
    }

    private void line_Click(object sender, EventArgs e)
    {
        _currentShape = new Line();
    }

    private void pictureBox1_Paint(object sender, PaintEventArgs e)
    {
        if (_currentShape != null)
        {
            var Center = new Point((_startPoint.X + _endPoint.X) / 2, (_startPoint.Y + _endPoint.Y) / 2);
            // При перерисовке PictureBox рисуем динамическую фигуру
            if (_currentShape is Line)
            {
                e.Graphics.DrawLine(new Pen(_currentColor, _currentWidth), _startPoint, _endPoint);
            }
            else if (_currentShape is Figures.Rectangle)
            {
                int width = Math.Abs(_startPoint.X - _endPoint.X);
                int height = Math.Abs(_startPoint.Y - _endPoint.Y);
                e.Graphics.DrawRectangle(new Pen(_currentColor, _currentWidth), Math.Min(_startPoint.X, _endPoint.X),
                    Math.Min(_startPoint.Y, _endPoint.Y), width, height);
            }
            else if (_currentShape is Square)
            {
                int sideLength = Math.Max(Math.Abs(_startPoint.X - _endPoint.X), Math.Abs(_startPoint.Y - _endPoint.Y));
                e.Graphics.DrawRectangle(new Pen(_currentColor, _currentWidth), Math.Min(_startPoint.X, _endPoint.X),
                    Math.Min(_startPoint.Y, _endPoint.Y), sideLength, sideLength);
            }
            else if (_currentShape is Circle)
            {
                int radius = (int)Math.Sqrt(Math.Pow(_endPoint.X - _startPoint.X, 2) +
                                            Math.Pow(_endPoint.Y - _startPoint.Y, 2));
                e.Graphics.DrawEllipse(new Pen(_currentColor, _currentWidth), _startPoint.X - radius, _startPoint.Y - radius, 2 * radius,
                    2 * radius);
            }
            else if (_currentShape is Ellipse)
            {
                int horizontalRadius = Math.Abs(_startPoint.X - _endPoint.X) / 2;
                int verticalRadius = Math.Abs(_startPoint.Y - _endPoint.Y) / 2;
                e.Graphics.DrawEllipse(new Pen(_currentColor, _currentWidth), Math.Min(_startPoint.X, _endPoint.X),
                    Math.Min(_startPoint.Y, _endPoint.Y), 2 * horizontalRadius, 2 * verticalRadius);
            }
            else if (_currentShape is Triangle)
            {
                // Calculate side lengths based on start and end points (same as in MouseUp)
                int side1 = (int)Math.Sqrt(Math.Pow(_endPoint.X - _startPoint.X, 2) + Math.Pow(_endPoint.Y - _startPoint.Y, 2));
                int side2 = (int)Math.Sqrt(Math.Pow(_endPoint.X - _startPoint.X, 2) + Math.Pow(_startPoint.Y - _endPoint.Y, 2));
                int side3 = (int)Math.Sqrt(Math.Pow(_startPoint.X - _endPoint.X, 2) + Math.Pow(_startPoint.Y - _endPoint.Y, 2));
                Point point1 = new Point(Center.X, Center.Y - side1 / 2);
                Point point2 = new Point(Center.X + side2 / 2, Center.Y + side2 / 2);
                Point point3 = new Point(Center.X - side3 / 2, Center.Y + side3 / 2);
                Point[] points = { point1, point2, point3 };
                e.Graphics.DrawPolygon(new Pen(_currentColor, _currentWidth), points);
            }
            else if (_currentShape is Rhomb)
            {
                // Calculate width and height based on start and end points (same as in MouseUp)
                int width = Math.Abs(_startPoint.X - _endPoint.X);
                int height = Math.Abs(_startPoint.Y - _endPoint.Y);
                Point point1 = new Point(Center.X, Center.Y - height / 2);
                Point point2 = new Point(Center.X + width / 2, Center.Y);
                Point point3 = new Point(Center.X, Center.Y + height / 2);
                Point point4 = new Point(Center.X - width / 2, Center.Y);
                Point[] points = { point1, point2, point3, point4 };
                e.Graphics.DrawPolygon(new Pen(_currentColor, _currentWidth), points);
            }
        }
    }

    private void button13_Click(object sender, EventArgs e)
    {
        _currentShape = null;
        _choosedTool = ChosenToolType.Filling;
    }

    private void button14_Click(object sender, EventArgs e)
    {
        _currentShape = null;
        _choosedTool = ChosenToolType.Pipette;
    }

    private Color GetPixelColor(Point location)
    {
        if (pictureBox1.Image != null)
        {
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            if (location.X >= 0 && location.X < bitmap.Width && location.Y >= 0 && location.Y < bitmap.Height)
            {
                return bitmap.GetPixel(location.X, location.Y);
            }
        }
        return Color.Transparent; // Если пиксель за пределами изображения, возвращаем прозрачный цвет
    }

    private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
    {
        if (_choosedTool == ChosenToolType.Pipette && e.Button == MouseButtons.Left)
        {
            _currentColor = GetPixelColor(e.Location);
            _pen.Color = _currentColor;
            button5.BackColor = _currentColor;
        }
    }

    private void toolStripSplitButton1_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Загрузка выбранного изображения
                    Image image = Image.FromFile(openFileDialog.FileName);

                    // Отображение изображения на PictureBox
                    pictureBox1.Image = new Bitmap(image);
                    _map = new Bitmap(pictureBox1.Image);

                    // Инициализация объекта Graphics для рисования на изображении
                    _graphics = Graphics.FromImage(_map);

                    // Сохранение текущего изображения в истории
                    _history.AddToHistory(new Bitmap(_map));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при открытии файла: {ex.Message}");
                }
            }
        }
    }

    private void toolStripButton4_Click(object sender, EventArgs e)
    {
        _history.Redo(ref pictureBox1, ref _graphics, ref _map);
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        Console.WriteLine($@"{e.KeyCode}, {e.Control}");
        if (e.Control && e.KeyCode == Keys.Z)
        {
            if (e.Shift)
            {
                _history.Redo(ref pictureBox1, ref _graphics, ref _map); // Redo
            }
            else
            {
                _history.Undo(ref pictureBox1, ref _graphics, ref _map); // Undo
            }
        }
    }
}