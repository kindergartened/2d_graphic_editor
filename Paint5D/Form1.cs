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
    /// ������ ��� ������������ ����� ��������� ������� ���� ��� PictureBox, 
    /// ��� ������ ������� �������������� ��������������� ������� ������ _paintBase.
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
    /// ����� ������ ����� ��� ���������
    /// </summary>
    private void button3_Click(object sender, EventArgs e)
    {
        _paintBase.SetColor(((Button)sender).BackColor);
    }

    /// <summary>
    /// ������ ������ ColorDialog ��� ������ ������������ �����
    /// </summary>
    private void button5_Click(object sender, EventArgs e)
    {
        if (colorDialog1.ShowDialog() == DialogResult.OK)
        {
            _paintBase.SetColor(((Button)sender).BackColor);
        }
    }

    /// <summary>
    /// ������ �������� pictureBox (������� ���������)
    /// </summary>
    private void toolStripButton1_Click(object sender, EventArgs e)
    {
        _paintBase.Clear(pictureBox1);
    }

    /// <summary>
    /// �������� �������� ��� ������ ������� ����� / �����
    /// </summary>
    private void trackBar1_ValueChanged(object sender, EventArgs e)
    {
        _paintBase.SetThickness(trackBar1.Value);
    }

    /// <summary>
    /// ������ ���������� �����������
    /// </summary>
    private void toolStripButton2_Click(object sender, EventArgs e)
    {
        saveFileDialog1.Filter = @"JPG(*.JPG)|*.jpg";

        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            if (pictureBox1 != null)
                pictureBox1.Image.Save(saveFileDialog1.FileName);
    }

    /// <summary>
    /// ������ ������ ���������
    /// </summary>
    private void toolStripButton3_Click(object sender, EventArgs e)
    {
        _paintBase.UndoChanges(pictureBox1);
    }

    /// <summary>
    /// ������ ��������� ����������
    /// </summary>
    private void circle_Click(object sender, EventArgs e)
    {
        _paintBase.CurrentShape = new Circle();
    }

    /// <summary>
    /// ������ ��������� ��������
    /// </summary>
    private void square_Click(object sender, EventArgs e)
    {
        _paintBase.CurrentShape = new Square();
    }

    /// <summary>
    /// ������ ��������� ��������������
    /// </summary>
    private void rectangle_Click(object sender, EventArgs e)
    {
        _paintBase.CurrentShape = new Figures.Rectangle();
    }

    /// <summary>
    /// ������ ��������� ������������
    /// </summary>
    private void triangle_Click(object sender, EventArgs e)
    {
        _paintBase.CurrentShape = new Triangle();
    }

    /// <summary>
    /// ������ ��������� �����
    /// </summary>
    private void romb_Click(object sender, EventArgs e)
    {
        _paintBase.CurrentShape = new Rhomb();
    }

    /// <summary>
    /// ������ ��������� �����
    /// </summary>
    private void line_Click(object sender, EventArgs e)
    {
        _paintBase.CurrentShape = new Line();
    }

    /// <summary>
    /// ������ �������
    /// </summary>
    private void pictureBox1_Paint(object sender, PaintEventArgs e)
    {
        _paintBase.Paint_Handler(e, pictureBox1);
    }

    /// <summary>
    /// ����� ������ �������� �����������
    /// </summary>
    private void ChoseTool(object sender, EventArgs e)
    {
        ToolType tool = (ToolType)int.Parse(((Button)sender).Tag.ToString() ?? string.Empty);
        _paintBase.SetTool(tool);
    }

    /// <summary>
    /// ������ �������. � ���� ������, ���� ������ ���������� Pipette � ������ ����� ������ ����, 
    /// �� ���������� ������� callback, ������� �������� ���� ������� � ����� ����� 
    /// � �������� ��� � ������� callback. � ������ ������, callback ������������� 
    /// ���� ������ button5 � ���������� ���� �������.
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
    /// ������ �������� �����. ��� ����� �� ���� �������� ���������� 
    /// ����������� ���������� ���� OpenFileDialog, ������� 
    /// ��������� ������������ ������� ���� �����������.
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
                    MessageBox.Show($@"������ ��� �������� �����: {ex.Message}");
                }
            }
        }
    }

    /// <summary>
    /// ������ �������� � ���������� ��������
    /// </summary>
    private void toolStripButton4_Click(object sender, EventArgs e)
    {
        _paintBase.RedoChanges(pictureBox1);
    }

    /// <summary>
    /// ���������� ��������� ������ Ctrl+Z ��� ������ Undo
    /// � Ctrl+Shift+Z ��� ������ Redo
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