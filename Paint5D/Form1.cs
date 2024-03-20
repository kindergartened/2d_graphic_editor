using Figures;
using Rectangle = System.Drawing.Rectangle;

namespace Paint5D;

public partial class Form1 : Form
{
    private bool _isMouse = false;

    private readonly ArrayPoints _arrayPoints = new(2);
    private Bitmap _map = new(100, 100);
    private Graphics? _graphics;
    private readonly Pen _pen = new(Color.Black, 3f);
    private readonly Pen _erase = new(Color.White, 12f);
    private int _choosedTool;
    private Shape? _currentShape; // добавл€ем переменную дл€ текущей выбранной фигуры
    private Point _startPoint;
    private Point _endPoint;

    private void SetBitMapSize()
    {
        Rectangle rectangle = Screen.PrimaryScreen.Bounds; //определ€ет разрешение пользовател€
        _map = new Bitmap(rectangle.Width, rectangle.Height);
        _graphics = Graphics.FromImage(_map);
        _pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
        _pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
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
    }

    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
        _isMouse = false;
        _endPoint = e.Location;

        // —оздаем выбранную фигуру на основе начальной и конечной точек
        if (_currentShape != null)
        {
            _currentShape.Center = new Point((_startPoint.X + _endPoint.X) / 2, (_startPoint.Y + _endPoint.Y) / 2);

            if (_currentShape is Line)
            {
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
                // «десь вы можете реализовать логику дл€ создани€ треугольника
                // Ќапример, можно использовать начальную и конечную точки как вершины треугольника
            }
            else if (_currentShape is Rhomb)
            {
                // «десь вы можете реализовать логику дл€ создани€ ромба
            }

            _currentShape.Draw(_graphics);
            pictureBox1.Image = _map;
            _currentShape = null;
        }
        else
        {
            _arrayPoints.ResetPoints();
        }
    }

    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
        if (!_isMouse) return;
        if (_currentShape != null)
        {
            // ѕри движении мыши рисуем динамическую фигуру
            _endPoint = e.Location;
            pictureBox1.Invalidate();
        }
        else
        {
            _arrayPoints.SetPoint(e.X, e.Y);
            if (_arrayPoints.GetPointsCount() >= 2)
                if (_choosedTool == 1 || _choosedTool == 2)
                {
                    _graphics.DrawLines(_choosedTool == 1 ? _pen : _erase, _arrayPoints.GetPoints());
                    pictureBox1.Image = _map;
                    _arrayPoints.SetPoint(e.X, e.Y);
                }
        }
    }

    //универсальна€ кнопка цветовой палитры
    private void button3_Click(object sender, EventArgs e)
    {
        _pen.Color = ((Button)sender).BackColor;
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
        _graphics.Clear(pictureBox1.BackColor);
        pictureBox1.Image = _map;
    }

    private void trackBar1_ValueChanged(object sender, EventArgs e)
    {
        _pen.Width = trackBar1.Value;
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
        saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";

        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            if (pictureBox1 != null)
                pictureBox1.Image.Save(saveFileDialog1.FileName);
    }

    private void button11_Click(object sender, EventArgs e)
    {
        _choosedTool = 2;
    }

    private void button12_Click(object sender, EventArgs e)
    {
        _choosedTool = 1;
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
        //метод удалени€ последней добавленной линии
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
            // ѕри перерисовке PictureBox рисуем динамическую фигуру
            if (_currentShape is Line)
            {
                e.Graphics.DrawLine(new Pen(Color.Black), _startPoint, _endPoint);
            }
            else if (_currentShape is Figures.Rectangle)
            {
                int width = Math.Abs(_startPoint.X - _endPoint.X);
                int height = Math.Abs(_startPoint.Y - _endPoint.Y);
                e.Graphics.DrawRectangle(new Pen(Color.Black), Math.Min(_startPoint.X, _endPoint.X),
                    Math.Min(_startPoint.Y, _endPoint.Y), width, height);
            }
            else if (_currentShape is Square)
            {
                int sideLength = Math.Max(Math.Abs(_startPoint.X - _endPoint.X), Math.Abs(_startPoint.Y - _endPoint.Y));
                e.Graphics.DrawRectangle(new Pen(Color.Black), Math.Min(_startPoint.X, _endPoint.X),
                    Math.Min(_startPoint.Y, _endPoint.Y), sideLength, sideLength);
            }
            else if (_currentShape is Circle)
            {
                int radius = (int)Math.Sqrt(Math.Pow(_endPoint.X - _startPoint.X, 2) +
                                            Math.Pow(_endPoint.Y - _startPoint.Y, 2));
                e.Graphics.DrawEllipse(new Pen(Color.Black), _startPoint.X - radius, _startPoint.Y - radius, 2 * radius,
                    2 * radius);
            }
            else if (_currentShape is Ellipse)
            {
                int horizontalRadius = Math.Abs(_startPoint.X - _endPoint.X) / 2;
                int verticalRadius = Math.Abs(_startPoint.Y - _endPoint.Y) / 2;
                e.Graphics.DrawEllipse(new Pen(Color.Black), Math.Min(_startPoint.X, _endPoint.X),
                    Math.Min(_startPoint.Y, _endPoint.Y), 2 * horizontalRadius, 2 * verticalRadius);
            }
            else if (_currentShape is Triangle)
            {
                Point[] points = new Point[3];
                points[0] = _startPoint;
                points[1] = new Point((_startPoint.X + _endPoint.X) / 2, _endPoint.Y);
                points[2] = _endPoint;
                e.Graphics.DrawPolygon(new Pen(Color.Black), points);
            }
            else if (_currentShape is Rhomb)
            {
                Point[] points = new Point[4];
                points[0] = _startPoint;
                points[1] = new Point(_endPoint.X, _startPoint.Y + (_endPoint.Y - _startPoint.Y) / 2);
                points[2] = _endPoint;
                points[3] = new Point(_startPoint.X - (_endPoint.X - _startPoint.X), _startPoint.Y + (_endPoint.Y - _startPoint.Y) / 2);
                e.Graphics.DrawPolygon(new Pen(Color.Black), points);
            }
        }
    }
}