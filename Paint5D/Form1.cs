using Figures;

namespace Paint5D;

public partial class Form1 : Form
{
    private PaintBase _paintBase;

    public Form1()
    {
        InitializeComponent();
        _paintBase = new();
    }

    /// <summary>
    /// Данный код представляет собой обработку событий мыши для PictureBox, 
    /// где каждое событие обрабатывается соответствующим методом класса _paintBase.
    /// </summary>
    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
        _paintBase.MouseDown_Hanler(e, pictureBox1);
    }
    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
        _paintBase.MouseUp_Handler(e, pictureBox1);
    }
    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
        _paintBase.MouseMove_Handler(e, pictureBox1);
    }

    /// <summary>
    /// Метод выбора цвета для рисования
    /// </summary>
    private void button3_Click(object sender, EventArgs e)
    {
        _paintBase.SetColor(((Button)sender).BackColor);
    }

    /// <summary>
    /// Кнопка вызова ColorDialog для выбора собственного цвета
    /// </summary>
    private void button5_Click(object sender, EventArgs e)
    {
        if (colorDialog1.ShowDialog() == DialogResult.OK)
        {
            _paintBase.SetColor(((Button)sender).BackColor);
        }
    }

    /// <summary>
    /// Кнопка очищения pictureBox (области рисования)
    /// </summary>
    private void toolStripButton1_Click(object sender, EventArgs e)
    {
        _paintBase.Clear(pictureBox1);
    }

    /// <summary>
    /// Ползунок трекбара для выбора толщины кисти / фигур
    /// </summary>
    private void trackBar1_ValueChanged(object sender, EventArgs e)
    {
        _paintBase.SetThickness(trackBar1.Value);
    }

    /// <summary>
    /// Кнопка сохранения изображения
    /// </summary>
    private void toolStripButton2_Click(object sender, EventArgs e)
    {
        saveFileDialog1.Filter = @"JPG(*.JPG)|*.jpg";

        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            if (pictureBox1 != null)
                pictureBox1.Image.Save(saveFileDialog1.FileName);
    }

    /// <summary>
    /// Кнопка отмены изменения
    /// </summary>
    private void toolStripButton3_Click(object sender, EventArgs e)
    {
        _paintBase.UndoChanges(pictureBox1);
    }

    /// <summary>
    /// Кнопка отрисовки окружности
    /// </summary>
    private void circle_Click(object sender, EventArgs e)
    {
        _paintBase.CurrentShape = new Circle();
    }

    /// <summary>
    /// Кнопка отрисовки квадрата
    /// </summary>
    private void square_Click(object sender, EventArgs e)
    {
        _paintBase.CurrentShape = new Square();
    }

    /// <summary>
    /// Кнопка отрисовки прямоугольника
    /// </summary>
    private void rectangle_Click(object sender, EventArgs e)
    {
        _paintBase.CurrentShape = new Figures.Rectangle();
    }

    /// <summary>
    /// Кнопка отрисовки треугольника
    /// </summary>
    private void triangle_Click(object sender, EventArgs e)
    {
        _paintBase.CurrentShape = new Triangle();
    }

    /// <summary>
    /// Кнопка отрисовки ромба
    /// </summary>
    private void romb_Click(object sender, EventArgs e)
    {
        _paintBase.CurrentShape = new Rhomb();
    }

    /// <summary>
    /// Кнопка отрисовки линии
    /// </summary>
    private void line_Click(object sender, EventArgs e)
    {
        _paintBase.CurrentShape = new Line();
    }

    /// <summary>
    /// Кнопка заливки
    /// </summary>
    private void pictureBox1_Paint(object sender, PaintEventArgs e)
    {
        _paintBase.Paint_Handler(e, pictureBox1);
    }

    /// <summary>
    /// Метод выбора текущего инструмента
    /// </summary>
    private void ChoseTool(object sender, EventArgs e)
    {
        ToolType tool = (ToolType)int.Parse(((Button)sender).Tag.ToString() ?? string.Empty);
        _paintBase.SetTool(tool);
    }

    /// <summary>
    /// Кнопка пипетки. В этом методе, если выбран инструмент Pipette и нажата левая кнопка мыши, 
    /// то вызывается функция callback, которая получает цвет пикселя в точке клика 
    /// и передает его в функцию callback. В данном случае, callback устанавливает 
    /// цвет кнопки button5 в полученный цвет пикселя.
    /// </summary>
    private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
    {
        _paintBase.MouseClick_Handler(e,  pictureBox1,color =>
        {
            button5.BackColor = color;
            return null;
        });
    }

    /// <summary>
    /// Кнопка открытия файла. При клике на этом элементе управления 
    /// открывается диалоговое окно OpenFileDialog, которое 
    /// позволяет пользователю выбрать файл изображения.
    /// </summary>
    private void toolStripSplitButton1_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = @"Image Files(*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromFile(openFileDialog.FileName);
                    _paintBase.SetImage(image, pictureBox1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($@"Ошибка при открытии файла: {ex.Message}");
                }
            }
        }
    }

    /// <summary>
    /// Кнопка возврата к удаленному варианту
    /// </summary>
    private void toolStripButton4_Click(object sender, EventArgs e)
    {
        _paintBase.RedoChanges(pictureBox1);
    }

    /// <summary>
    /// Реализация сочетания клавиш Ctrl+Z для вызова Undo
    /// и Ctrl+Shift+Z для вызова Redo
    /// </summary>
    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        Console.WriteLine($@"{e.KeyCode}, {e.Control}");
        if (e.Control && e.KeyCode == Keys.Z)
        {
            if (e.Shift)
            {
                _paintBase.RedoChanges(pictureBox1);
            }
            else
            {
                _paintBase.UndoChanges(pictureBox1);
            }
        }
    }
}