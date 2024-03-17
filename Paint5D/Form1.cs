using System.Net.Http.Headers;
using Figures;

namespace Paint5D;

public partial class Form1 : Form
{
    private bool isMouse = false;

    private ArrayPoints arrayPoints = new(2);
    Bitmap map = new(100, 100);
    Graphics graphics;
    Pen pen = new(Color.Black, 3f);

    private void SetBitMapSize()
    {
        Rectangle rectangle = Screen.PrimaryScreen.Bounds; //определяет разрешение пользователя
        map = new Bitmap(rectangle.Width, rectangle.Height);
        graphics = Graphics.FromImage(map);
        pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
        pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
    }

    public Form1()
    {
        InitializeComponent();
        SetBitMapSize();
    }

    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
        isMouse = true;
    }

    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
        isMouse = false;
        arrayPoints.ResetPoints();
    }

    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
        if (!isMouse) return;

        arrayPoints.SetPoint(e.X, e.Y);

        if (arrayPoints.GetPointsCount() >= 2)
        {
            graphics.DrawLines(pen, arrayPoints.GetPoints());
            pictureBox1.Image = map;
            arrayPoints.SetPoint(e.X, e.Y);
        }
    }

    private void button3_Click(object sender, EventArgs e) //универсальная кнопка цветовой палитры
    {
        pen.Color = ((Button)sender).BackColor;
    }

    private void button5_Click(object sender, EventArgs e) //color dialog
    {
        if (colorDialog1.ShowDialog() == DialogResult.OK)
        {
            pen.Color = colorDialog1.Color;
            ((Button)sender).BackColor = colorDialog1.Color;
        }
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
        graphics.Clear(pictureBox1.BackColor);
        pictureBox1.Image = map;
    }

    private void trackBar1_ValueChanged(object sender, EventArgs e)
    {
        pen.Width = trackBar1.Value;
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
        saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";

        if(saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            if (pictureBox1 != null)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }
    }
}