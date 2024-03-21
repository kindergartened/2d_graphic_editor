using Figures;
using Rectangle = System.Drawing.Rectangle;

namespace Paint5D;

public class PaintBase
{
    private readonly ArrayPoints _arrayPoints = new(2);
    private Bitmap _map = new(100, 100);
    private Graphics? _graphics;
    private readonly Pen _pen = new(Color.Black, 3f);
    private readonly Pen _erase = new(Color.White, 12f);
    private ToolType _choosedTool;
    private Point _startPoint;
    private Point _endPoint;
    private Color _currentColor = Color.Black;
    private float _currentWidth = 3f;
    private ChangesHistory _history = new();
    
    public bool IsMouse { get; set; }
    public Shape? CurrentShape { get; set; }

    public PaintBase()
    {
        _choosedTool = ToolType.Brush;
        SetBitMapSize();
    }

    public void MouseDown_Hanler(MouseEventArgs e, PictureBox picBox)
    {
        IsMouse = true;
        _startPoint = e.Location;
        if (_choosedTool == ToolType.Filling)
        {
            FillArea(e.Location, _currentColor, picBox);
            picBox.Invalidate();
        }
    }

    public void MouseUp_Handler(MouseEventArgs e, PictureBox picBox)
    {
        IsMouse = false;
        _endPoint = e.Location;

        if (CurrentShape != null)
        {
            CurrentShape.Center = new Point((_startPoint.X + _endPoint.X) / 2, (_startPoint.Y + _endPoint.Y) / 2);
            CurrentShape.DrawDynamic(ref _graphics, _startPoint, _endPoint, _currentWidth, _currentColor);
            CurrentShape.Draw(_graphics, _currentWidth, _currentColor);
            picBox.Image = _map;
            CurrentShape = null;
        }
        else
        {
            _arrayPoints.ResetPoints();
        }
        _history.AddToHistory(new Bitmap(_map));
    }

    public void MouseMove_Handler(MouseEventArgs e, PictureBox picBox)
    {
        if (!IsMouse) return;
        if (CurrentShape != null)
        {
            _endPoint = e.Location;
            picBox.Invalidate();
        }
        else
        {
            _arrayPoints.SetPoint(e.X, e.Y);
            if (_arrayPoints.GetPointsCount() >= 2)
                DrawWithTool(_choosedTool, e, picBox);
        }
    }

    public void Paint_Handler(PaintEventArgs e, PictureBox picBox)
    {
        if (CurrentShape != null)
        {
            CurrentShape.Center = new Point((_startPoint.X + _endPoint.X) / 2, (_startPoint.Y + _endPoint.Y) / 2);
            var eGraphics = e.Graphics;
            CurrentShape.DrawDynamic(ref eGraphics, _startPoint, _endPoint, _currentWidth, _currentColor);
        }
    }

    public void MouseClick_Handler(MouseEventArgs e, PictureBox picBox, Func<Color, dynamic?> callback)
    {
        if (_choosedTool == ToolType.Pipette && e.Button == MouseButtons.Left)
        {
            _currentColor = GetPixelColor(e.Location, picBox);
            _pen.Color = _currentColor;
            callback(_currentColor);
        }
    }

    public void SetColor(Color newColor)
    {
        _currentColor = newColor;
        _pen.Color = newColor;
    }

    public void SetThickness(float thickness)
    {
        _pen.Width = thickness;
        _currentWidth = thickness;
    }
    
    public void SetTool(ToolType tool)
    {
        _choosedTool = tool;
    }

    public void Clear(PictureBox picBox)
    {
        _graphics?.Clear(picBox.BackColor);
        picBox.Image = _map;
    }

    public void UndoChanges(PictureBox picBox)
    {
        _history.Undo(ref picBox, ref _graphics, ref _map);
    }
    
    public void RedoChanges(PictureBox picBox)
    {
        _history.Redo(ref picBox, ref _graphics, ref _map);
    }

    public void SetImage(Image image, PictureBox picBox)
    {
        picBox.Image = new Bitmap(image);
        _map = new Bitmap(picBox.Image);
        _graphics = Graphics.FromImage(_map);

        _history.AddToHistory(new Bitmap(_map));
    }
    
    private void SetBitMapSize()
    {
        Rectangle screenBounds = Screen.PrimaryScreen.Bounds;
        _map = new Bitmap(screenBounds.Width, screenBounds.Height);
        _graphics = Graphics.FromImage(_map);
        _pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
        _pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        _history.AddToHistory(new Bitmap(_map));
    }
    
    private void FillArea(Point startPoint, Color fillColor, PictureBox picBox)
    {
        if (picBox.Image != null)
        {
            Bitmap bitmap = (Bitmap)picBox.Image;
            Color targetColor = bitmap.GetPixel(startPoint.X, startPoint.Y);
            FloodFill.Fill(bitmap, startPoint, targetColor, fillColor);
            picBox.Refresh();
        }
    }
    
    private void DrawWithTool(ToolType tool, MouseEventArgs e, PictureBox picBox)
    {
        if (tool != ToolType.Brush && tool != ToolType.Erase) return;
        
        switch (tool)
        {
            case ToolType.Brush:
                _graphics?.DrawLines(_pen, _arrayPoints.GetPoints());
                break;
            case ToolType.Erase:
                _graphics?.DrawLines(_erase, _arrayPoints.GetPoints());
                break;
        }

        picBox.Image = _map;
        _arrayPoints.SetPoint(e.X, e.Y);
    }
    
    private Color GetPixelColor(Point location, PictureBox picBox)
    {
        if (picBox.Image != null)
        {
            Bitmap bitmap = (Bitmap)picBox.Image;
            if (location.X >= 0 && location.X < bitmap.Width && location.Y >= 0 && location.Y < bitmap.Height)
            {
                return bitmap.GetPixel(location.X, location.Y);
            }
        }
        return Color.Transparent;
    }
}