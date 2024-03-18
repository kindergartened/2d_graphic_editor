using System.Net.Http.Headers;
using Figures;

namespace Paint5D;

public partial class Form1 : Form
{
    private bool isMouse = false;

    private readonly ArrayPoints arrayPoints = new(2);
    private Bitmap map = new(100, 100);
    private Graphics graphics;
    private readonly Pen pen = new(Color.Black, 3f);
    private readonly Pen erase = new(Color.White, 12f);
    private int choosedTool = 1;

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


    private void pictureBox1_MouseDown(object sender, MouseEventArgs e) { isMouse = true; }

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
            if (choosedTool == 1 || choosedTool == 2)
            {
                graphics.DrawLines(choosedTool == 1 ? pen : erase, arrayPoints.GetPoints());
                pictureBox1.Image = map;
                arrayPoints.SetPoint(e.X, e.Y);
            }
    }

    //универсальная кнопка цветовой палитры
    private void button3_Click(object sender, EventArgs e) { pen.Color = ((Button)sender).BackColor; }

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

    private void trackBar1_ValueChanged(object sender, EventArgs e) { pen.Width = trackBar1.Value; }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
        saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";

        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            if (pictureBox1 != null)
                pictureBox1.Image.Save(saveFileDialog1.FileName);
    }

    private void button11_Click(object sender, EventArgs e) { choosedTool = 2; }

    private void button12_Click(object sender, EventArgs e) { choosedTool = 1; }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
        //метод удаления последней добавленной линии
    }
}