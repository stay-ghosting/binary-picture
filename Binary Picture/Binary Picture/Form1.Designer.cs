
namespace Binary_Picture
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_denary = new System.Windows.Forms.Label();
            this.lbl_binary = new System.Windows.Forms.Label();
            this.lbl_hex = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_b = new System.Windows.Forms.TrackBar();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tb_g = new System.Windows.Forms.TrackBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tb_r = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.radio_hex = new System.Windows.Forms.RadioButton();
            this.textBox_r = new System.Windows.Forms.TextBox();
            this.radio_denary = new System.Windows.Forms.RadioButton();
            this.textBox_g = new System.Windows.Forms.TextBox();
            this.radio_binary = new System.Windows.Forms.RadioButton();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pen_color_square = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.file_new = new System.Windows.Forms.ToolStripMenuItem();
            this.file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.file_save_hex = new System.Windows.Forms.ToolStripMenuItem();
            this.file_save_binary = new System.Windows.Forms.ToolStripMenuItem();
            this.file_save_denary = new System.Windows.Forms.ToolStripMenuItem();
            this.file_load = new System.Windows.Forms.ToolStripMenuItem();
            this.file_load_hex = new System.Windows.Forms.ToolStripMenuItem();
            this.file_load_binary = new System.Windows.Forms.ToolStripMenuItem();
            this.file_load_denary = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.canvas_holder = new System.Windows.Forms.Panel();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_always_on_top = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pen_color_square)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.canvas_holder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 561);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_hex);
            this.panel3.Controls.Add(this.lbl_binary);
            this.panel3.Controls.Add(this.lbl_denary);
            this.panel3.Location = new System.Drawing.Point(9, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 73);
            this.panel3.TabIndex = 9;
            // 
            // lbl_denary
            // 
            this.lbl_denary.AutoSize = true;
            this.lbl_denary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_denary.ForeColor = System.Drawing.Color.White;
            this.lbl_denary.Location = new System.Drawing.Point(4, 46);
            this.lbl_denary.Name = "lbl_denary";
            this.lbl_denary.Size = new System.Drawing.Size(44, 13);
            this.lbl_denary.TabIndex = 6;
            this.lbl_denary.Text = "Denary:";
            // 
            // lbl_binary
            // 
            this.lbl_binary.AutoSize = true;
            this.lbl_binary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_binary.ForeColor = System.Drawing.Color.White;
            this.lbl_binary.Location = new System.Drawing.Point(4, 33);
            this.lbl_binary.Name = "lbl_binary";
            this.lbl_binary.Size = new System.Drawing.Size(39, 13);
            this.lbl_binary.TabIndex = 5;
            this.lbl_binary.Text = "Binary:";
            // 
            // lbl_hex
            // 
            this.lbl_hex.AutoSize = true;
            this.lbl_hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_hex.ForeColor = System.Drawing.Color.White;
            this.lbl_hex.Location = new System.Drawing.Point(4, 20);
            this.lbl_hex.Name = "lbl_hex";
            this.lbl_hex.Size = new System.Drawing.Size(29, 13);
            this.lbl_hex.TabIndex = 3;
            this.lbl_hex.Text = "Hex:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Color of hovered pixel:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "By Rheon Mais 2021 v1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel4.Controls.Add(this.pen_color_square);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBox_b);
            this.panel4.Controls.Add(this.radio_binary);
            this.panel4.Controls.Add(this.textBox_g);
            this.panel4.Controls.Add(this.radio_denary);
            this.panel4.Controls.Add(this.textBox_r);
            this.panel4.Controls.Add(this.radio_hex);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.tb_r);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.tb_g);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.tb_b);
            this.panel4.Location = new System.Drawing.Point(9, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 304);
            this.panel4.TabIndex = 9;
            // 
            // tb_b
            // 
            this.tb_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_b.LargeChange = 20;
            this.tb_b.Location = new System.Drawing.Point(37, 251);
            this.tb_b.Maximum = 255;
            this.tb_b.Name = "tb_b";
            this.tb_b.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_b.Size = new System.Drawing.Size(128, 45);
            this.tb_b.SmallChange = 5;
            this.tb_b.TabIndex = 13;
            this.tb_b.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_b.Scroll += new System.EventHandler(this.tb_b_Scroll);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Blue;
            this.pictureBox4.Location = new System.Drawing.Point(10, 243);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 30);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // tb_g
            // 
            this.tb_g.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_g.LargeChange = 20;
            this.tb_g.Location = new System.Drawing.Point(39, 182);
            this.tb_g.Maximum = 255;
            this.tb_g.Name = "tb_g";
            this.tb_g.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_g.Size = new System.Drawing.Size(128, 45);
            this.tb_g.SmallChange = 5;
            this.tb_g.TabIndex = 12;
            this.tb_g.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_g.Scroll += new System.EventHandler(this.tb_g_Scroll);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Lime;
            this.pictureBox3.Location = new System.Drawing.Point(10, 176);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 30);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // tb_r
            // 
            this.tb_r.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tb_r.LargeChange = 20;
            this.tb_r.Location = new System.Drawing.Point(39, 110);
            this.tb_r.Maximum = 255;
            this.tb_r.Name = "tb_r";
            this.tb_r.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_r.Size = new System.Drawing.Size(128, 45);
            this.tb_r.SmallChange = 5;
            this.tb_r.TabIndex = 11;
            this.tb_r.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_r.Scroll += new System.EventHandler(this.tb_r_Scroll);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(10, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 30);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // radio_hex
            // 
            this.radio_hex.AutoSize = true;
            this.radio_hex.BackColor = System.Drawing.Color.Transparent;
            this.radio_hex.ForeColor = System.Drawing.Color.White;
            this.radio_hex.Location = new System.Drawing.Point(69, 76);
            this.radio_hex.Name = "radio_hex";
            this.radio_hex.Size = new System.Drawing.Size(44, 17);
            this.radio_hex.TabIndex = 19;
            this.radio_hex.Text = "Hex";
            this.radio_hex.UseVisualStyleBackColor = false;
            this.radio_hex.Click += new System.EventHandler(this.radio_hex_Click);
            // 
            // textBox_r
            // 
            this.textBox_r.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.textBox_r.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_r.ForeColor = System.Drawing.Color.White;
            this.textBox_r.Location = new System.Drawing.Point(10, 140);
            this.textBox_r.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_r.MaxLength = 8;
            this.textBox_r.Name = "textBox_r";
            this.textBox_r.Size = new System.Drawing.Size(58, 13);
            this.textBox_r.TabIndex = 15;
            this.textBox_r.TextChanged += new System.EventHandler(this.textBox_r_TextChanged);
            // 
            // radio_denary
            // 
            this.radio_denary.AutoSize = true;
            this.radio_denary.BackColor = System.Drawing.Color.Transparent;
            this.radio_denary.ForeColor = System.Drawing.Color.White;
            this.radio_denary.Location = new System.Drawing.Point(121, 76);
            this.radio_denary.Name = "radio_denary";
            this.radio_denary.Size = new System.Drawing.Size(59, 17);
            this.radio_denary.TabIndex = 20;
            this.radio_denary.Text = "Denary";
            this.radio_denary.UseVisualStyleBackColor = false;
            this.radio_denary.Click += new System.EventHandler(this.radio_denary_Click);
            // 
            // textBox_g
            // 
            this.textBox_g.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.textBox_g.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_g.ForeColor = System.Drawing.Color.White;
            this.textBox_g.Location = new System.Drawing.Point(10, 212);
            this.textBox_g.MaxLength = 8;
            this.textBox_g.Name = "textBox_g";
            this.textBox_g.Size = new System.Drawing.Size(58, 13);
            this.textBox_g.TabIndex = 16;
            this.textBox_g.TextChanged += new System.EventHandler(this.textBox_g_TextChanged);
            // 
            // radio_binary
            // 
            this.radio_binary.AutoSize = true;
            this.radio_binary.BackColor = System.Drawing.Color.Transparent;
            this.radio_binary.ForeColor = System.Drawing.Color.White;
            this.radio_binary.Location = new System.Drawing.Point(9, 76);
            this.radio_binary.Name = "radio_binary";
            this.radio_binary.Size = new System.Drawing.Size(54, 17);
            this.radio_binary.TabIndex = 18;
            this.radio_binary.Text = "Binary";
            this.radio_binary.UseVisualStyleBackColor = false;
            this.radio_binary.Click += new System.EventHandler(this.radio_binary_Click);
            // 
            // textBox_b
            // 
            this.textBox_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.textBox_b.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_b.ForeColor = System.Drawing.Color.White;
            this.textBox_b.Location = new System.Drawing.Point(10, 279);
            this.textBox_b.MaxLength = 8;
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(58, 13);
            this.textBox_b.TabIndex = 17;
            this.textBox_b.TextChanged += new System.EventHandler(this.textBox_b_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Paint Color";
            // 
            // pen_color_square
            // 
            this.pen_color_square.BackColor = System.Drawing.Color.Blue;
            this.pen_color_square.Location = new System.Drawing.Point(8, 23);
            this.pen_color_square.Name = "pen_color_square";
            this.pen_color_square.Size = new System.Drawing.Size(50, 47);
            this.pen_color_square.TabIndex = 21;
            this.pen_color_square.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.help});
            this.menuStrip1.Location = new System.Drawing.Point(91, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(89, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip";
            // 
            // file
            // 
            this.file.BackColor = System.Drawing.Color.DimGray;
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_new,
            this.file_save,
            this.file_load});
            this.file.ForeColor = System.Drawing.Color.Black;
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(37, 20);
            this.file.Text = "File";
            // 
            // file_new
            // 
            this.file_new.BackColor = System.Drawing.Color.White;
            this.file_new.ForeColor = System.Drawing.Color.Black;
            this.file_new.Name = "file_new";
            this.file_new.Size = new System.Drawing.Size(180, 22);
            this.file_new.Text = "New";
            this.file_new.Click += new System.EventHandler(this.file_new_Click);
            // 
            // file_save
            // 
            this.file_save.BackColor = System.Drawing.Color.White;
            this.file_save.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_save_hex,
            this.file_save_binary,
            this.file_save_denary});
            this.file_save.Name = "file_save";
            this.file_save.Size = new System.Drawing.Size(180, 22);
            this.file_save.Text = "Save As";
            // 
            // file_save_hex
            // 
            this.file_save_hex.Name = "file_save_hex";
            this.file_save_hex.Size = new System.Drawing.Size(111, 22);
            this.file_save_hex.Text = "Hex";
            this.file_save_hex.Click += new System.EventHandler(this.file_save_hex_Click);
            // 
            // file_save_binary
            // 
            this.file_save_binary.Name = "file_save_binary";
            this.file_save_binary.Size = new System.Drawing.Size(111, 22);
            this.file_save_binary.Text = "Binary";
            this.file_save_binary.Click += new System.EventHandler(this.file_save_binary_Click);
            // 
            // file_save_denary
            // 
            this.file_save_denary.Name = "file_save_denary";
            this.file_save_denary.Size = new System.Drawing.Size(111, 22);
            this.file_save_denary.Text = "Denary";
            this.file_save_denary.Click += new System.EventHandler(this.file_save_denary_Click);
            // 
            // file_load
            // 
            this.file_load.BackColor = System.Drawing.Color.White;
            this.file_load.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_load_hex,
            this.file_load_binary,
            this.file_load_denary});
            this.file_load.Name = "file_load";
            this.file_load.Size = new System.Drawing.Size(180, 22);
            this.file_load.Text = "Load";
            // 
            // file_load_hex
            // 
            this.file_load_hex.Name = "file_load_hex";
            this.file_load_hex.Size = new System.Drawing.Size(111, 22);
            this.file_load_hex.Text = "Hex";
            this.file_load_hex.Click += new System.EventHandler(this.file_load_hex_Click);
            // 
            // file_load_binary
            // 
            this.file_load_binary.Name = "file_load_binary";
            this.file_load_binary.Size = new System.Drawing.Size(111, 22);
            this.file_load_binary.Text = "Binary";
            this.file_load_binary.Click += new System.EventHandler(this.file_load_binary_Click);
            // 
            // file_load_denary
            // 
            this.file_load_denary.Name = "file_load_denary";
            this.file_load_denary.Size = new System.Drawing.Size(111, 22);
            this.file_load_denary.Text = "Denary";
            this.file_load_denary.Click += new System.EventHandler(this.file_load_denary_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.DimGray;
            this.help.ForeColor = System.Drawing.Color.Black;
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(44, 20);
            this.help.Text = "Help";
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // canvas_holder
            // 
            this.canvas_holder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.canvas_holder.Controls.Add(this.Canvas);
            this.canvas_holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas_holder.Location = new System.Drawing.Point(238, 0);
            this.canvas_holder.Name = "canvas_holder";
            this.canvas_holder.Size = new System.Drawing.Size(611, 561);
            this.canvas_holder.TabIndex = 9;
            this.canvas_holder.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_holder_Paint);
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Canvas.Location = new System.Drawing.Point(80, 58);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(384, 372);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox_always_on_top);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 470);
            this.panel1.TabIndex = 23;
            // 
            // checkBox_always_on_top
            // 
            this.checkBox_always_on_top.AutoSize = true;
            this.checkBox_always_on_top.ForeColor = System.Drawing.Color.White;
            this.checkBox_always_on_top.Location = new System.Drawing.Point(10, 441);
            this.checkBox_always_on_top.Name = "checkBox_always_on_top";
            this.checkBox_always_on_top.Size = new System.Drawing.Size(98, 17);
            this.checkBox_always_on_top.TabIndex = 10;
            this.checkBox_always_on_top.Text = "Always on top?";
            this.checkBox_always_on_top.UseVisualStyleBackColor = true;
            this.checkBox_always_on_top.CheckedChanged += new System.EventHandler(this.checkBox_always_on_top_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(849, 561);
            this.Controls.Add(this.canvas_holder);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Binary Picture";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pen_color_square)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.canvas_holder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel canvas_holder;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem file_new;
        private System.Windows.Forms.ToolStripMenuItem file_save;
        private System.Windows.Forms.ToolStripMenuItem file_save_hex;
        private System.Windows.Forms.ToolStripMenuItem file_save_binary;
        private System.Windows.Forms.ToolStripMenuItem file_save_denary;
        private System.Windows.Forms.ToolStripMenuItem file_load;
        private System.Windows.Forms.ToolStripMenuItem file_load_hex;
        private System.Windows.Forms.ToolStripMenuItem file_load_binary;
        private System.Windows.Forms.ToolStripMenuItem file_load_denary;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pen_color_square;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.RadioButton radio_binary;
        private System.Windows.Forms.TextBox textBox_g;
        private System.Windows.Forms.RadioButton radio_denary;
        private System.Windows.Forms.TextBox textBox_r;
        private System.Windows.Forms.RadioButton radio_hex;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar tb_r;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TrackBar tb_g;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TrackBar tb_b;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_hex;
        private System.Windows.Forms.Label lbl_binary;
        private System.Windows.Forms.Label lbl_denary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox_always_on_top;
    }
}

