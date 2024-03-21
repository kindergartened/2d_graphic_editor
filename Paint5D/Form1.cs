using Figures;
using Rectangle = System.Drawing.Rectangle;

namespace Paint5D;

public partial class Form1 : Form
{
    private PaintBase _paintBase;

    public Form1()
    {
        InitializeComponent();
        _paintBase = new();
    }


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

    //универсальная кнопка цветовой палитры
    private void button3_Click(object sender, EventArgs e)
    {
        _paintBase.SetColor(((Button)sender).BackColor);
    }

    private void button5_Click(object sender, EventArgs e) //color dialog
    {
        if (colorDialog1.ShowDialog() == DialogResult.OK)
        {
            _paintBase.SetColor(((Button)sender).BackColor);
        }
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
        _paintBase.Clear(pictureBox1);
    }

    private void trackBar1_ValueChanged(object sender, EventArgs e)
    {
        _paintBase.SetThickness(trackBar1.Value);
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
        saveFileDialog1.Filter = @"JPG(*.JPG)|*.jpg";

        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            if (pictureBox1 != null)
                pictureBox1.Image.Save(saveFileDialog1.FileName);
    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
        _paintBase.UndoChanges(pictureBox1);
    }

    private void circle_Click(object sender, EventArgs e)
    {
        _paintBase.CurrentShape = new Circle();
    }

    private void square_Click(object sender, EventArgs e)
    {
        _paintBase.CurrentShape = new Square();
    }

    private void rectangle_Click(object sender, EventArgs e)
    {
        _paintBase.CurrentShape = new Figures.Rectangle();
    }

    private void triangle_Click(object sender, EventArgs e)
    {
        _paintBase.CurrentShape = new Triangle();
    }

    private void romb_Click(object sender, EventArgs e)
    {
        _paintBase.CurrentShape = new Rhomb();
    }

    private void line_Click(object sender, EventArgs e)
    {
        _paintBase.CurrentShape = new Line();
    }

    private void pictureBox1_Paint(object sender, PaintEventArgs e)
    {
        _paintBase.Paint_Handler(e, pictureBox1);
    }

    private void ChoseTool(object sender, EventArgs e)
    {
        ToolType tool = (ToolType)int.Parse(((Button)sender).Tag.ToString() ?? string.Empty);
        _paintBase.SetTool(tool);
    }

    private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
    {
        _paintBase.MouseClick_Handler(e,  pictureBox1,color =>
        {
            button5.BackColor = color;
            return null;
        });
    }

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

    private void toolStripButton4_Click(object sender, EventArgs e)
    {
        _paintBase.RedoChanges(pictureBox1);
    }

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