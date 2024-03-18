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
        panel1 = new Panel();
        button12 = new Button();
        button11 = new Button();
        label2 = new Label();
        trackBar1 = new TrackBar();
        label1 = new Label();
        button10 = new Button();
        button9 = new Button();
        button8 = new Button();
        button7 = new Button();
        button6 = new Button();
        button5 = new Button();
        button4 = new Button();
        button3 = new Button();
        button2 = new Button();
        button1 = new Button();
        colorDialog1 = new ColorDialog();
        saveFileDialog1 = new SaveFileDialog();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        toolStrip1.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = Color.White;
        pictureBox1.Dock = DockStyle.Fill;
        pictureBox1.Location = new Point(0, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(1100, 659);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        pictureBox1.MouseDown += pictureBox1_MouseDown;
        pictureBox1.MouseMove += pictureBox1_MouseMove;
        pictureBox1.MouseUp += pictureBox1_MouseUp;
        // 
        // toolStrip1
        // 
        toolStrip1.BackColor = Color.White;
        toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1, toolStripButton1, toolStripButton2, toolStripSeparator1, toolStripButton3, toolStripButton4 });
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
        // 
        // panel1
        // 
        panel1.BackColor = Color.Lavender;
        panel1.Controls.Add(button12);
        panel1.Controls.Add(button11);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(trackBar1);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(button10);
        panel1.Controls.Add(button9);
        panel1.Controls.Add(button8);
        panel1.Controls.Add(button7);
        panel1.Controls.Add(button6);
        panel1.Controls.Add(button5);
        panel1.Controls.Add(button4);
        panel1.Controls.Add(button3);
        panel1.Controls.Add(button2);
        panel1.Controls.Add(button1);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 25);
        panel1.Name = "panel1";
        panel1.Size = new Size(1100, 90);
        panel1.TabIndex = 2;
        // 
        // button12
        // 
        button12.BackgroundImage = Properties.Resources.brush__2_;
        button12.BackgroundImageLayout = ImageLayout.Stretch;
        button12.Cursor = Cursors.Hand;
        button12.FlatAppearance.BorderSize = 0;
        button12.FlatAppearance.MouseDownBackColor = Color.Lavender;
        button12.FlatAppearance.MouseOverBackColor = Color.Lavender;
        button12.FlatStyle = FlatStyle.Flat;
        button12.Location = new Point(190, 12);
        button12.Name = "button12";
        button12.Size = new Size(25, 25);
        button12.TabIndex = 14;
        button12.UseVisualStyleBackColor = true;
        button12.Click += button12_Click;
        // 
        // button11
        // 
        button11.BackgroundImage = Properties.Resources.eraser;
        button11.BackgroundImageLayout = ImageLayout.Stretch;
        button11.Cursor = Cursors.Hand;
        button11.FlatAppearance.BorderSize = 0;
        button11.FlatAppearance.MouseDownBackColor = Color.Lavender;
        button11.FlatAppearance.MouseOverBackColor = Color.Lavender;
        button11.FlatStyle = FlatStyle.Flat;
        button11.Location = new Point(190, 43);
        button11.Name = "button11";
        button11.Size = new Size(25, 25);
        button11.TabIndex = 13;
        button11.UseVisualStyleBackColor = false;
        button11.Click += button11_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        label2.ForeColor = SystemColors.ControlDarkDark;
        label2.Location = new Point(256, 71);
        label2.Name = "label2";
        label2.Size = new Size(105, 16);
        label2.TabIndex = 12;
        label2.Text = "Brush thickness";
        label2.Click += label2_Click;
        // 
        // trackBar1
        // 
        trackBar1.Cursor = Cursors.Hand;
        trackBar1.LargeChange = 10;
        trackBar1.Location = new Point(241, 23);
        trackBar1.Maximum = 20;
        trackBar1.Name = "trackBar1";
        trackBar1.Size = new Size(142, 45);
        trackBar1.TabIndex = 11;
        trackBar1.ValueChanged += trackBar1_ValueChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        label1.ForeColor = SystemColors.ControlDarkDark;
        label1.Location = new Point(62, 71);
        label1.Name = "label1";
        label1.Size = new Size(47, 16);
        label1.TabIndex = 10;
        label1.Text = "Colors";
        // 
        // button10
        // 
        button10.BackColor = Color.Black;
        button10.Cursor = Cursors.Hand;
        button10.FlatAppearance.BorderColor = Color.Gray;
        button10.FlatStyle = FlatStyle.Flat;
        button10.Location = new Point(12, 43);
        button10.Name = "button10";
        button10.Size = new Size(25, 25);
        button10.TabIndex = 9;
        button10.UseVisualStyleBackColor = false;
        button10.Click += button3_Click;
        // 
        // button9
        // 
        button9.BackColor = Color.FromArgb(128, 128, 255);
        button9.Cursor = Cursors.Hand;
        button9.FlatAppearance.BorderColor = Color.Gray;
        button9.FlatStyle = FlatStyle.Flat;
        button9.Location = new Point(43, 43);
        button9.Name = "button9";
        button9.Size = new Size(25, 25);
        button9.TabIndex = 8;
        button9.UseVisualStyleBackColor = false;
        button9.Click += button3_Click;
        // 
        // button8
        // 
        button8.BackColor = Color.FromArgb(0, 192, 0);
        button8.Cursor = Cursors.Hand;
        button8.FlatAppearance.BorderColor = Color.Gray;
        button8.FlatStyle = FlatStyle.Flat;
        button8.Location = new Point(74, 43);
        button8.Name = "button8";
        button8.Size = new Size(25, 25);
        button8.TabIndex = 7;
        button8.UseVisualStyleBackColor = false;
        button8.Click += button3_Click;
        // 
        // button7
        // 
        button7.BackColor = Color.FromArgb(0, 0, 192);
        button7.Cursor = Cursors.Hand;
        button7.FlatAppearance.BorderColor = Color.Gray;
        button7.FlatStyle = FlatStyle.Flat;
        button7.Location = new Point(105, 43);
        button7.Name = "button7";
        button7.Size = new Size(25, 25);
        button7.TabIndex = 6;
        button7.UseVisualStyleBackColor = false;
        button7.Click += button3_Click;
        // 
        // button6
        // 
        button6.BackColor = Color.Gold;
        button6.Cursor = Cursors.Hand;
        button6.FlatAppearance.BorderColor = Color.Gray;
        button6.FlatStyle = FlatStyle.Flat;
        button6.Location = new Point(136, 12);
        button6.Name = "button6";
        button6.Size = new Size(25, 25);
        button6.TabIndex = 5;
        button6.UseVisualStyleBackColor = false;
        button6.Click += button3_Click;
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
        button5.Location = new Point(136, 43);
        button5.Name = "button5";
        button5.Size = new Size(25, 25);
        button5.TabIndex = 4;
        button5.UseVisualStyleBackColor = false;
        button5.Click += button5_Click;
        // 
        // button4
        // 
        button4.BackColor = SystemColors.Highlight;
        button4.Cursor = Cursors.Hand;
        button4.FlatAppearance.BorderColor = Color.Gray;
        button4.FlatStyle = FlatStyle.Flat;
        button4.Location = new Point(105, 12);
        button4.Name = "button4";
        button4.Size = new Size(25, 25);
        button4.TabIndex = 3;
        button4.UseVisualStyleBackColor = false;
        button4.Click += button3_Click;
        // 
        // button3
        // 
        button3.BackColor = Color.White;
        button3.Cursor = Cursors.Hand;
        button3.FlatAppearance.BorderColor = Color.Gray;
        button3.FlatStyle = FlatStyle.Flat;
        button3.Location = new Point(12, 12);
        button3.Name = "button3";
        button3.Size = new Size(25, 25);
        button3.TabIndex = 2;
        button3.UseVisualStyleBackColor = false;
        button3.Click += button3_Click;
        // 
        // button2
        // 
        button2.BackColor = Color.Firebrick;
        button2.Cursor = Cursors.Hand;
        button2.FlatAppearance.BorderColor = Color.Gray;
        button2.FlatStyle = FlatStyle.Flat;
        button2.ForeColor = SystemColors.ControlText;
        button2.Location = new Point(43, 12);
        button2.Name = "button2";
        button2.Size = new Size(25, 25);
        button2.TabIndex = 1;
        button2.UseVisualStyleBackColor = false;
        button2.Click += button3_Click;
        // 
        // button1
        // 
        button1.BackColor = Color.DarkOrange;
        button1.Cursor = Cursors.Hand;
        button1.FlatAppearance.BorderColor = Color.Gray;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Location = new Point(74, 12);
        button1.Name = "button1";
        button1.Size = new Size(25, 25);
        button1.TabIndex = 0;
        button1.UseVisualStyleBackColor = false;
        button1.Click += button3_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1100, 659);
        Controls.Add(panel1);
        Controls.Add(toolStrip1);
        Controls.Add(pictureBox1);
        Name = "Form1";
        Text = " NEW PAINT 2024";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBox1;
    private ToolStrip toolStrip1;
    private ToolStripButton toolStripButton1;
    private Panel panel1;
    private Label label1;
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
    private Label label2;
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
}