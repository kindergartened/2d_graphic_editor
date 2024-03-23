namespace Paint5D;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        pictureBox1 = new PictureBox();
        toolStrip1 = new ToolStrip();
        toolStripSplitButton1 = new ToolStripButton();
        toolStripButton1 = new ToolStripButton();
        toolStripButton2 = new ToolStripButton();
        toolStripSeparator1 = new ToolStripSeparator();
        toolStripButton3 = new ToolStripButton();
        toolStripButton4 = new ToolStripButton();
        toolStripButton5 = new ToolStripButton();
        toolStripButton6 = new ToolStripButton();
        panel1 = new Panel();
        groupBox4 = new GroupBox();
        line = new Button();
        romb = new Button();
        triangle = new Button();
        rectangle = new Button();
        square = new Button();
        circle = new Button();
        groupBox3 = new GroupBox();
        trackBar1 = new TrackBar();
        groupBox2 = new GroupBox();
        button13 = new Button();
        button11 = new Button();
        button12 = new Button();
        button14 = new Button();
        groupBox1 = new GroupBox();
        button8 = new Button();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        button9 = new Button();
        button10 = new Button();
        colorDialog1 = new ColorDialog();
        saveFileDialog1 = new SaveFileDialog();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        toolStrip1.SuspendLayout();
        panel1.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
        groupBox2.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pictureBox1.BackColor = Color.White;
        pictureBox1.Location = new Point(0, 124);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(1100, 535);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        pictureBox1.Paint += pictureBox1_Paint;
        pictureBox1.MouseClick += pictureBox1_MouseClick;
        pictureBox1.MouseDown += pictureBox1_MouseDown;
        pictureBox1.MouseMove += pictureBox1_MouseMove;
        pictureBox1.MouseUp += pictureBox1_MouseUp;
        // 
        // toolStrip1
        // 
        toolStrip1.BackColor = Color.White;
        toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1, toolStripButton1, toolStripButton2, toolStripSeparator1, toolStripButton3, toolStripButton4, toolStripButton5, toolStripButton6 });
        toolStrip1.Location = new Point(0, 0);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new Size(1100, 25);
        toolStrip1.TabIndex = 1;
        toolStrip1.Text = "toolStrip1";
        // 
        // toolStripSplitButton1
        // 
        toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
        toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
        toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
        toolStripSplitButton1.Name = "toolStripSplitButton1";
        toolStripSplitButton1.Size = new Size(59, 22);
        toolStripSplitButton1.Text = "Open file";
        toolStripSplitButton1.Click += toolStripSplitButton1_Click;
        // 
        // toolStripButton1
        // 
        toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
        toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
        toolStripButton1.ImageTransparentColor = Color.Magenta;
        toolStripButton1.Name = "toolStripButton1";
        toolStripButton1.Size = new Size(74, 22);
        toolStripButton1.Text = "Clear layout";
        toolStripButton1.Click += toolStripButton1_Click;
        // 
        // toolStripButton2
        // 
        toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
        toolStripButton2.Image = Properties.Resources.save;
        toolStripButton2.ImageTransparentColor = Color.Magenta;
        toolStripButton2.Name = "toolStripButton2";
        toolStripButton2.Size = new Size(23, 22);
        toolStripButton2.Text = "Save file";
        toolStripButton2.Click += toolStripButton2_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(6, 25);
        // 
        // toolStripButton3
        // 
        toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
        toolStripButton3.Image = Properties.Resources.rotate_left;
        toolStripButton3.ImageTransparentColor = Color.Magenta;
        toolStripButton3.Name = "toolStripButton3";
        toolStripButton3.Size = new Size(23, 22);
        toolStripButton3.Text = "toolStripButton3";
        toolStripButton3.Click += toolStripButton3_Click;
        // 
        // toolStripButton4
        // 
        toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
        toolStripButton4.ForeColor = SystemColors.ActiveCaptionText;
        toolStripButton4.Image = Properties.Resources.rotate_right;
        toolStripButton4.ImageTransparentColor = Color.Magenta;
        toolStripButton4.Name = "toolStripButton4";
        toolStripButton4.Size = new Size(23, 22);
        toolStripButton4.Text = "toolStripButton4";
        toolStripButton4.Click += toolStripButton4_Click;
        // 
        // toolStripButton5
        // 
        toolStripButton5.Alignment = ToolStripItemAlignment.Right;
        toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
        toolStripButton5.Image = Properties.Resources.info;
        toolStripButton5.ImageTransparentColor = Color.Magenta;
        toolStripButton5.Name = "toolStripButton5";
        toolStripButton5.Size = new Size(23, 22);
        // 
        // toolStripButton6
        // 
        toolStripButton6.Alignment = ToolStripItemAlignment.Right;
        toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
        toolStripButton6.Image = Properties.Resources.help__1_;
        toolStripButton6.ImageTransparentColor = Color.Magenta;
        toolStripButton6.Name = "toolStripButton6";
        toolStripButton6.Size = new Size(23, 22);
        toolStripButton6.Text = "toolStripButton6";
        // 
        // panel1
        // 
        panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        panel1.BackColor = Color.Lavender;
        panel1.Controls.Add(groupBox4);
        panel1.Controls.Add(groupBox3);
        panel1.Controls.Add(groupBox2);
        panel1.Controls.Add(groupBox1);
        panel1.Location = new Point(0, 25);
        panel1.Name = "panel1";
        panel1.Size = new Size(1100, 101);
        panel1.TabIndex = 2;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(line);
        groupBox4.Controls.Add(romb);
        groupBox4.Controls.Add(triangle);
        groupBox4.Controls.Add(rectangle);
        groupBox4.Controls.Add(square);
        groupBox4.Controls.Add(circle);
        groupBox4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        groupBox4.ForeColor = SystemColors.GrayText;
        groupBox4.Location = new Point(501, 5);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(147, 93);
        groupBox4.TabIndex = 21;
        groupBox4.TabStop = false;
        groupBox4.Text = "Shapes";
        // 
        // line
        // 
        line.BackgroundImage = Properties.Resources.diagonal_line;
        line.BackgroundImageLayout = ImageLayout.Stretch;
        line.Cursor = Cursors.Hand;
        line.FlatAppearance.BorderSize = 0;
        line.FlatAppearance.MouseDownBackColor = Color.Lavender;
        line.FlatAppearance.MouseOverBackColor = Color.Lavender;
        line.FlatStyle = FlatStyle.Flat;
        line.Location = new Point(101, 55);
        line.Name = "line";
        line.Size = new Size(25, 25);
        line.TabIndex = 22;
        line.UseVisualStyleBackColor = true;
        line.Click += line_Click;
        // 
        // romb
        // 
        romb.BackgroundImage = Properties.Resources.priority;
        romb.BackgroundImageLayout = ImageLayout.Stretch;
        romb.Cursor = Cursors.Hand;
        romb.FlatAppearance.BorderSize = 0;
        romb.FlatAppearance.MouseDownBackColor = Color.Lavender;
        romb.FlatAppearance.MouseOverBackColor = Color.Lavender;
        romb.FlatStyle = FlatStyle.Flat;
        romb.Location = new Point(61, 55);
        romb.Name = "romb";
        romb.Size = new Size(25, 25);
        romb.TabIndex = 21;
        romb.UseVisualStyleBackColor = true;
        romb.Click += romb_Click;
        // 
        // triangle
        // 
        triangle.BackgroundImage = Properties.Resources.chlorine;
        triangle.BackgroundImageLayout = ImageLayout.Stretch;
        triangle.Cursor = Cursors.Hand;
        triangle.FlatAppearance.BorderSize = 0;
        triangle.FlatAppearance.MouseDownBackColor = Color.Lavender;
        triangle.FlatAppearance.MouseOverBackColor = Color.Lavender;
        triangle.FlatStyle = FlatStyle.Flat;
        triangle.Location = new Point(20, 55);
        triangle.Name = "triangle";
        triangle.Size = new Size(25, 25);
        triangle.TabIndex = 20;
        triangle.UseVisualStyleBackColor = true;
        triangle.Click += triangle_Click;
        // 
        // rectangle
        // 
        rectangle.BackgroundImage = Properties.Resources.rectangle;
        rectangle.BackgroundImageLayout = ImageLayout.Stretch;
        rectangle.Cursor = Cursors.Hand;
        rectangle.FlatAppearance.BorderSize = 0;
        rectangle.FlatAppearance.MouseDownBackColor = Color.Lavender;
        rectangle.FlatAppearance.MouseOverBackColor = Color.Lavender;
        rectangle.FlatStyle = FlatStyle.Flat;
        rectangle.Location = new Point(101, 24);
        rectangle.Name = "rectangle";
        rectangle.Size = new Size(25, 25);
        rectangle.TabIndex = 19;
        rectangle.UseVisualStyleBackColor = true;
        rectangle.Click += rectangle_Click;
        // 
        // square
        // 
        square.BackgroundImage = Properties.Resources.square;
        square.BackgroundImageLayout = ImageLayout.Stretch;
        square.Cursor = Cursors.Hand;
        square.FlatAppearance.BorderSize = 0;
        square.FlatAppearance.MouseDownBackColor = Color.Lavender;
        square.FlatAppearance.MouseOverBackColor = Color.Lavender;
        square.FlatStyle = FlatStyle.Flat;
        square.Location = new Point(61, 24);
        square.Name = "square";
        square.Size = new Size(25, 25);
        square.TabIndex = 18;
        square.UseVisualStyleBackColor = true;
        square.Click += square_Click;
        // 
        // circle
        // 
        circle.BackgroundImage = Properties.Resources.circle_ring;
        circle.BackgroundImageLayout = ImageLayout.Stretch;
        circle.Cursor = Cursors.Hand;
        circle.FlatAppearance.BorderSize = 0;
        circle.FlatAppearance.MouseDownBackColor = Color.Lavender;
        circle.FlatAppearance.MouseOverBackColor = Color.Lavender;
        circle.FlatStyle = FlatStyle.Flat;
        circle.Location = new Point(20, 24);
        circle.Name = "circle";
        circle.Size = new Size(25, 25);
        circle.TabIndex = 17;
        circle.UseVisualStyleBackColor = true;
        circle.Click += circle_Click;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(trackBar1);
        groupBox3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        groupBox3.ForeColor = SystemColors.GrayText;
        groupBox3.Location = new Point(323, 5);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(179, 93);
        groupBox3.TabIndex = 20;
        groupBox3.TabStop = false;
        groupBox3.Text = "Thickness";
        // 
        // trackBar1
        // 
        trackBar1.Cursor = Cursors.Hand;
        trackBar1.LargeChange = 10;
        trackBar1.Location = new Point(19, 33);
        trackBar1.Maximum = 20;
        trackBar1.Name = "trackBar1";
        trackBar1.Size = new Size(142, 45);
        trackBar1.TabIndex = 11;
        trackBar1.ValueChanged += trackBar1_ValueChanged;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(button13);
        groupBox2.Controls.Add(button11);
        groupBox2.Controls.Add(button12);
        groupBox2.Controls.Add(button14);
        groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        groupBox2.ForeColor = SystemColors.GrayText;
        groupBox2.Location = new Point(211, 5);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(114, 93);
        groupBox2.TabIndex = 19;
        groupBox2.TabStop = false;
        groupBox2.Text = "Tools";
        // 
        // button13
        // 
        button13.BackgroundImage = Properties.Resources.paintBucket;
        button13.BackgroundImageLayout = ImageLayout.Stretch;
        button13.Cursor = Cursors.Hand;
        button13.FlatAppearance.BorderSize = 0;
        button13.FlatAppearance.CheckedBackColor = SystemColors.Highlight;
        button13.FlatAppearance.MouseDownBackColor = Color.Lavender;
        button13.FlatAppearance.MouseOverBackColor = Color.Lavender;
        button13.FlatStyle = FlatStyle.Flat;
        button13.Location = new Point(65, 22);
        button13.Name = "button13";
        button13.Size = new Size(25, 25);
        button13.TabIndex = 16;
        button13.Tag = "3";
        button13.UseVisualStyleBackColor = true;
        button13.Click += ChoseTool;
        // 
        // button11
        // 
        button11.BackgroundImage = Properties.Resources.eraser;
        button11.BackgroundImageLayout = ImageLayout.Stretch;
        button11.Cursor = Cursors.Hand;
        button11.FlatAppearance.BorderSize = 0;
        button11.FlatAppearance.CheckedBackColor = SystemColors.Highlight;
        button11.FlatAppearance.MouseDownBackColor = Color.Lavender;
        button11.FlatAppearance.MouseOverBackColor = Color.Lavender;
        button11.FlatStyle = FlatStyle.Flat;
        button11.Location = new Point(24, 53);
        button11.Name = "button11";
        button11.Size = new Size(25, 25);
        button11.TabIndex = 13;
        button11.Tag = "2";
        button11.UseVisualStyleBackColor = false;
        button11.Click += ChoseTool;
        // 
        // button12
        // 
        button12.BackgroundImage = Properties.Resources.brush__2_;
        button12.BackgroundImageLayout = ImageLayout.Stretch;
        button12.Cursor = Cursors.Hand;
        button12.FlatAppearance.BorderSize = 0;
        button12.FlatAppearance.CheckedBackColor = SystemColors.Highlight;
        button12.FlatAppearance.MouseDownBackColor = Color.Lavender;
        button12.FlatAppearance.MouseOverBackColor = Color.Lavender;
        button12.FlatStyle = FlatStyle.Flat;
        button12.Location = new Point(24, 22);
        button12.Name = "button12";
        button12.Size = new Size(25, 25);
        button12.TabIndex = 14;
        button12.Tag = "1";
        button12.UseVisualStyleBackColor = true;
        button12.Click += ChoseTool;
        // 
        // button14
        // 
        button14.BackgroundImage = Properties.Resources.pipette;
        button14.BackgroundImageLayout = ImageLayout.Stretch;
        button14.Cursor = Cursors.Hand;
        button14.FlatAppearance.BorderSize = 0;
        button14.FlatAppearance.CheckedBackColor = SystemColors.Highlight;
        button14.FlatAppearance.MouseDownBackColor = Color.Lavender;
        button14.FlatAppearance.MouseOverBackColor = Color.Lavender;
        button14.FlatStyle = FlatStyle.Flat;
        button14.Location = new Point(65, 53);
        button14.Name = "button14";
        button14.Size = new Size(25, 25);
        button14.TabIndex = 15;
        button14.Tag = "4";
        button14.UseVisualStyleBackColor = false;
        button14.Click += ChoseTool;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(button8);
        groupBox1.Controls.Add(button1);
        groupBox1.Controls.Add(button2);
        groupBox1.Controls.Add(button3);
        groupBox1.Controls.Add(button4);
        groupBox1.Controls.Add(button5);
        groupBox1.Controls.Add(button6);
        groupBox1.Controls.Add(button7);
        groupBox1.Controls.Add(button9);
        groupBox1.Controls.Add(button10);
        groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        groupBox1.ForeColor = SystemColors.GrayText;
        groupBox1.Location = new Point(14, 5);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(200, 93);
        groupBox1.TabIndex = 18;
        groupBox1.TabStop = false;
        groupBox1.Text = "Colors";
        // 
        // button8
        // 
        button8.BackColor = Color.FromArgb(0, 192, 0);
        button8.Cursor = Cursors.Hand;
        button8.FlatAppearance.BorderColor = Color.Gray;
        button8.FlatStyle = FlatStyle.Flat;
        button8.Location = new Point(87, 53);
        button8.Name = "button8";
        button8.Size = new Size(25, 25);
        button8.TabIndex = 7;
        button8.UseVisualStyleBackColor = false;
        button8.Click += button3_Click;
        // 
        // button1
        // 
        button1.BackColor = Color.DarkOrange;
        button1.Cursor = Cursors.Hand;
        button1.FlatAppearance.BorderColor = Color.Gray;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Location = new Point(87, 22);
        button1.Name = "button1";
        button1.Size = new Size(25, 25);
        button1.TabIndex = 0;
        button1.UseVisualStyleBackColor = false;
        button1.Click += button3_Click;
        // 
        // button2
        // 
        button2.BackColor = Color.Firebrick;
        button2.Cursor = Cursors.Hand;
        button2.FlatAppearance.BorderColor = Color.Gray;
        button2.FlatStyle = FlatStyle.Flat;
        button2.ForeColor = SystemColors.ControlText;
        button2.Location = new Point(56, 22);
        button2.Name = "button2";
        button2.Size = new Size(25, 25);
        button2.TabIndex = 1;
        button2.UseVisualStyleBackColor = false;
        button2.Click += button3_Click;
        // 
        // button3
        // 
        button3.BackColor = Color.White;
        button3.Cursor = Cursors.Hand;
        button3.FlatAppearance.BorderColor = Color.Gray;
        button3.FlatStyle = FlatStyle.Flat;
        button3.Location = new Point(25, 22);
        button3.Name = "button3";
        button3.Size = new Size(25, 25);
        button3.TabIndex = 2;
        button3.UseVisualStyleBackColor = false;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.BackColor = SystemColors.Highlight;
        button4.Cursor = Cursors.Hand;
        button4.FlatAppearance.BorderColor = Color.Gray;
        button4.FlatStyle = FlatStyle.Flat;
        button4.Location = new Point(118, 22);
        button4.Name = "button4";
        button4.Size = new Size(25, 25);
        button4.TabIndex = 3;
        button4.UseVisualStyleBackColor = false;
        button4.Click += button3_Click;
        // 
        // button5
        // 
        button5.BackColor = Color.Transparent;
        button5.BackgroundImage = Properties.Resources.paintPalette;
        button5.BackgroundImageLayout = ImageLayout.Zoom;
        button5.Cursor = Cursors.Hand;
        button5.FlatAppearance.BorderColor = Color.Gray;
        button5.FlatAppearance.BorderSize = 0;
        button5.FlatStyle = FlatStyle.Flat;
        button5.Location = new Point(149, 53);
        button5.Name = "button5";
        button5.Size = new Size(25, 25);
        button5.TabIndex = 4;
        button5.UseVisualStyleBackColor = false;
        button5.Click += button5_Click;
        // 
        // button6
        // 
        button6.BackColor = Color.Gold;
        button6.Cursor = Cursors.Hand;
        button6.FlatAppearance.BorderColor = Color.Gray;
        button6.FlatStyle = FlatStyle.Flat;
        button6.Location = new Point(149, 22);
        button6.Name = "button6";
        button6.Size = new Size(25, 25);
        button6.TabIndex = 5;
        button6.UseVisualStyleBackColor = false;
        button6.Click += button3_Click;
        // 
        // button7
        // 
        button7.BackColor = Color.FromArgb(0, 0, 192);
        button7.Cursor = Cursors.Hand;
        button7.FlatAppearance.BorderColor = Color.Gray;
        button7.FlatStyle = FlatStyle.Flat;
        button7.Location = new Point(118, 53);
        button7.Name = "button7";
        button7.Size = new Size(25, 25);
        button7.TabIndex = 6;
        button7.UseVisualStyleBackColor = false;
        button7.Click += button3_Click;
        // 
        // button9
        // 
        button9.BackColor = Color.FromArgb(128, 128, 255);
        button9.Cursor = Cursors.Hand;
        button9.FlatAppearance.BorderColor = Color.Gray;
        button9.FlatStyle = FlatStyle.Flat;
        button9.Location = new Point(56, 53);
        button9.Name = "button9";
        button9.Size = new Size(25, 25);
        button9.TabIndex = 8;
        button9.UseVisualStyleBackColor = false;
        button9.Click += button3_Click;
        // 
        // button10
        // 
        button10.BackColor = Color.Black;
        button10.Cursor = Cursors.Hand;
        button10.FlatAppearance.BorderColor = Color.Gray;
        button10.FlatStyle = FlatStyle.Flat;
        button10.Location = new Point(25, 53);
        button10.Name = "button10";
        button10.Size = new Size(25, 25);
        button10.TabIndex = 9;
        button10.UseVisualStyleBackColor = false;
        button10.Click += button3_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1100, 659);
        Controls.Add(panel1);
        Controls.Add(toolStrip1);
        Controls.Add(pictureBox1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "Form1";
        Text = " NEW PAINT 2024";
        KeyDown += Form1_KeyDown;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        panel1.ResumeLayout(false);
        groupBox4.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
        groupBox2.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBox1;
    private ToolStrip toolStrip1;
    private ToolStripButton toolStripButton1;
    private Panel panel1;
    private Button button10;
    private Button button9;
    private Button button8;
    private Button button7;
    private Button button6;
    private Button button5;
    private Button button4;
    private Button button3;
    private Button button2;
    private Button button1;
    private TrackBar trackBar1;
    private ColorDialog colorDialog1;
    private ToolStripButton toolStripSplitButton1;
    private ToolStripButton toolStripButton2;
    private SaveFileDialog saveFileDialog1;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton toolStripButton3;
    private ToolStripButton toolStripButton4;
    private Button button11;
    private Button button12;
    private Button button13;
    private Button button14;
    private ToolStripButton toolStripButton5;
    private ToolStripButton toolStripButton6;
    private GroupBox groupBox1;
    private GroupBox groupBox3;
    private GroupBox groupBox2;
    private GroupBox groupBox4;
    private Button line;
    private Button romb;
    private Button triangle;
    private Button rectangle;
    private Button square;
    private Button circle;
}