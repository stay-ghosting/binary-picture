using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseNumber;

// TODO show current pen color.

namespace Binary_Picture
{
    public partial class Form1 : Form
    {
        public class Pixels
        {


            //              properties/fields

            // max 1000
            public int rows;
            public int columns;

            public Size pixelSize;

            public PictureBox[,] pixels;

            PictureBox canvas;


            //              constructors


            public Pixels(PictureBox canvasToUse, Form1 form1, int rows, int columns)
            {
                // sets canvas
                this.canvas = canvasToUse;
                // calculates size each pixel will be
                pixelSize = new Size((int)Math.Ceiling((double)canvas.Width / rows),
                                        (int)Math.Ceiling((double)canvas.Height / columns));
                // where every pixelwill be stored... setting size
                pixels = new PictureBox[rows, columns];

                // looping through ever row and collomn... populating it
                for (int i = 0; i < rows; i++)
                {
                    for (int ii = 0; ii < columns; ii++)
                    {
                        // gets ofset relative to 
                        PointF relativeOffset = new PointF(i * pixelSize.Width, ii * pixelSize.Height);
                        // finds x and y coordinates of the pixel
                        float locationX = canvas.Location.X + relativeOffset.X;
                        float locationY = canvas.Location.Y + relativeOffset.Y;
                        // location for pixel
                        // PointF pixelLocation = new PointF(locationX, locationY);
                        Point pixelLocation = new Point((int)relativeOffset.X, (int)relativeOffset.Y);
                        // creates rect and color
                        //RectangleF rect = new RectangleF(pixelLocation, pixelSize);
                        //Color color = Color.Black;
                        //// populates the pixels

                        // name for the pixels
                        string pixelName = i.ToString().PadLeft(3) +
                                            ii.ToString().PadLeft(3);

                        PictureBox currentPixel = new PictureBox
                        {
                            Name = $"{pixelName}",
                            Location = pixelLocation,
                            BackColor = Color.Black,
                            Size = pixelSize
                        };

                        currentPixel.MouseClick += form1.OnPixelClick;
                        currentPixel.MouseHover += form1.HoveringPixel;

                        pixels[i, ii] = currentPixel;
                        canvas.Controls.Add(currentPixel);
                    }
                }
            }


            //              Methods


            public void Clear()
            {
                for (int i = 0; i < pixels.GetLength(0); i++)
                {
                    for (int ii = 0; ii < pixels.GetLength(1); ii++)
                    {
                        pixels[i, ii].BackColor = Color.Black;
                    }
                }
            }

            public void ResizePizels(PictureBox canvasToUse)
            {
                // calculates size each pixel will be
                pixelSize = new Size((int)Math.Ceiling((double)canvasToUse.Width / pixels.GetLength(0)),
                                        (int)Math.Ceiling((double)canvasToUse.Height / pixels.GetLength(1)));

                for (int i = 0; i < pixels.GetLength(0); i++)
                {
                    for (int ii = 0; ii < pixels.GetLength(1); ii++)
                    {
                        PointF relativeOffset = new PointF(i * pixelSize.Width, ii * pixelSize.Height);

                        //float locationX = canvas.Location.X + relativeOffset.X;
                        //float locationY = canvas.Location.Y + relativeOffset.Y;

                        Point pixelLocation = new Point((int)relativeOffset.X, (int)relativeOffset.Y);

                        pixels[i, ii].Location = pixelLocation;
                        pixels[i, ii].Size = pixelSize;
                    }
                }
            }
        }

        Pixels pixels;
        Color penColor = Color.Blue;

        bool finishedLoading = false;
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnResize(EventArgs e)
        {
            if(finishedLoading)
                ResizeCanvas();
        }

        private void ResizeCanvas()
        {
            canvas_holder.Anchor = AnchorStyles.Right;
            canvas_holder.Dock = DockStyle.Fill;

            // get new size of canvas
            int newCanvasWidth = canvas_holder.Width;
            int newCanvasHeight = canvas_holder.Height;
            int canvasSizeInt = Math.Min(newCanvasWidth, newCanvasHeight);
            // set size
            Size canvasSize = new Size(canvasSizeInt, canvasSizeInt);
            Canvas.Size = canvasSize;
            Canvas.Location = Point.Empty;
            //set location
            Point center = new Point(canvas_holder.Width / 2, canvas_holder.Height / 2);
            Point offset = new Point(Canvas.Width / 2, Canvas.Height / 2);
            Point newPos = new Point(center.X - offset.X, center.Y - offset.Y);

            Canvas.Location = newPos;

            pixels.ResizePizels(Canvas);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // set mode to binary
            radio_binary_Click(this, new EventArgs());
            // set up color bars
            //tb_r.Value = penColor.R;
            //tb_g.Value = penColor.G;
            //tb_b.Value = penColor.B;
            tb_b.Value = 255;

            UpdateColorGUI();

            pixels = new Pixels(Canvas, this, 16, 16);
            ResizeCanvas();
            finishedLoading = true;
        }

        private void DeletePixels()
        {
            for (int i = 0; i < pixels.pixels.GetLength(0); i++)
            {
                for (int ii = 0; ii < pixels.pixels.GetLength(1); ii++)
                {
                    pixels.pixels[i, ii].Dispose();
                }
            }
        }


        public void OnPixelClick(object pixelBoxed, MouseEventArgs e)
        {
            PaintPixel(pixelBoxed);
        }
        public void HoveringPixel(object pixelBoxed, EventArgs e)
        {
            PictureBox pixel = (PictureBox)pixelBoxed;
            try
            {
                // hex
                string r = pixel.BackColor.R.ToString();
                string g = pixel.BackColor.G.ToString();
                string b = pixel.BackColor.B.ToString();

                string color = $"Denary: {r} {g} {b}";
                lbl_denary.Text = color;

                r = new Hex(pixel.BackColor.R).Value;
                g = new Hex(pixel.BackColor.G).Value;
                b = new Hex(pixel.BackColor.B).Value;

                string hexColor = $"Hex: {r} {g} {b}";
                lbl_hex.Text = hexColor;

                // binary
                r = new Binary(pixel.BackColor.R).Value;
                g = new Binary(pixel.BackColor.G).Value;
                b = new Binary(pixel.BackColor.B).Value;

                string binaryColor = $"Binary: {r} {g} {b}";
                lbl_binary.Text = binaryColor;

            }
            catch { }
        }

        public void PaintPixel(object pixelBoxed)
        {
            PictureBox pixel = (PictureBox)pixelBoxed;
            try
            {
                pixel.BackColor = penColor;
            }
            catch { }
        }

        private void file_new_Click(object sender, EventArgs e)
        {
            pixels.Clear();
        }

        // TODO make different save types
        private void SaveImage(int baseNumber)
        {
            string saveName;
            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "Save file as...";
                sfd.Filter = "CSV file |*.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    saveName = sfd.FileName;
                }
                else
                {
                    return;
                }
            }
            using (var file = new StreamWriter(saveName))
            {
                for (int i = 0; i < pixels.pixels.GetLength(0); i++)
                {
                    string line = "";

                    for (int ii = 0; ii < pixels.pixels.GetLength(1); ii++)
                    {

                        //
                        string r = new BaseNumber.BaseNumber(pixels.pixels[i, ii].BackColor.R, baseNumber).Value.ToString();
                        string g = new BaseNumber.BaseNumber(pixels.pixels[i, ii].BackColor.G, baseNumber).Value.ToString();
                        string b = new BaseNumber.BaseNumber(pixels.pixels[i, ii].BackColor.B, baseNumber).Value.ToString();

                        string rgb = "";
                        rgb = $"{r},{g},{b}";

                        // if last dont add comma
                        bool isLastInCol = (ii == 0);
                        if (!isLastInCol)
                            rgb = ';' + rgb;

                        line = line + rgb;
                    }
                    file.WriteLine(line);
                }
            }
        }

        private void LoadImage(int baseNumber)
        {

            // get line count and value per row of csv
            int rows = 0;
            int columns = 0;

            string fileName;

            // find file
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV file|*.csv";
                ofd.Title = "Load image from csv file";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                }
                else
                {
                    return;
                }
            }

            using (var reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    columns = reader.ReadLine().Split(';').Length;
                    rows++;
                }
            }

            // try once without changing anything to see if in correct format

            using (var reader = new StreamReader(fileName))
            {

                string[] columnValues;
                int rowIndex = 0;

                while (!reader.EndOfStream)
                {
                    string[] rgbsInRow = reader.ReadLine().Split(';');

                    for (int columnIndex = 0; columnIndex < rgbsInRow.Length; columnIndex++)
                    {
                        columnValues = rgbsInRow[columnIndex].Split(',');

                        string rString = columnValues[0];
                        string gString = columnValues[1];
                        string bString = columnValues[2];

                        try
                        {
                            int r = new BaseNumber.BaseNumber(rString, baseNumber).DenaryValue;
                            int g = new BaseNumber.BaseNumber(gString, baseNumber).DenaryValue;
                            int b = new BaseNumber.BaseNumber(bString, baseNumber).DenaryValue;

                            var tryParse = Color.FromArgb(255, r, g, b);
                        }
                        catch (FormatException)
                        {
                            CouldntLoadMessage();
                            return;
                        }
                        catch (ArgumentException)
                        {
                            CouldntLoadMessage();
                            return;
                        }
                    }

                    rowIndex++;
                }
            }

            DeletePixels();
            // set resolution of image
            pixels = new Pixels(Canvas, this, rows, columns);

            // set canvas
            using (var reader = new StreamReader(fileName))
            {

                string[] columnValues;
                int rowIndex = 0;

                while (!reader.EndOfStream)
                {
                    string[] rgbsInRow = reader.ReadLine().Split(';');

                    for (int columnIndex = 0; columnIndex < rgbsInRow.Length; columnIndex++)
                    {
                        columnValues = rgbsInRow[columnIndex].Split(',');

                        string rString = columnValues[0];
                        string gString = columnValues[1];
                        string bString = columnValues[2];

                        try
                        {
                            int r = new BaseNumber.BaseNumber(rString, baseNumber).DenaryValue;
                            int g = new BaseNumber.BaseNumber(gString, baseNumber).DenaryValue;
                            int b = new BaseNumber.BaseNumber(bString, baseNumber).DenaryValue;
                            pixels.pixels[rowIndex, columnIndex].BackColor = Color.FromArgb(255, r, g, b);
                        }
                        catch (FormatException)
                        {
                            CouldntLoadMessage();
                            return;
                        }
                        catch (ArgumentException)
                        {
                            CouldntLoadMessage();
                            return;
                        }
                    }

                    rowIndex++;
                }
            }

        }


        private void CouldntLoadMessage()
        {
            MessageBox.Show(@"CSV Unreadable!
check
    - Is it in correct form?
    - does each line have the same amount of values?
    - Is it in correct 8bit (hex/denary/binary) form?
    - Have you loaded it in corresponding hex/denary/binary?
");
        }

        private void file_save_hex_Click(object sender, EventArgs e)
        {
            SaveImage(16);
        }

        private void file_save_binary_Click(object sender, EventArgs e)
        {
            SaveImage(2);
        }

        private void file_save_denary_Click(object sender, EventArgs e)
        {
            SaveImage(10);
        }

        private void file_load_hex_Click(object sender, EventArgs e)
        {
            LoadImage(16);
        }

        private void file_load_binary_Click(object sender, EventArgs e)
        {
            LoadImage(2);
        }

        private void file_load_denary_Click(object sender, EventArgs e)
        {
            LoadImage(10);
        }

        private void radio_binary_Click(object sender, EventArgs e)
        {
            radio_denary.Checked = false;
            radio_hex.Checked = false;
            radio_binary.Checked = true;

            UpdateColorGUI();
        }

        private void radio_hex_Click(object sender, EventArgs e)
        {
            radio_denary.Checked = false;
            radio_binary.Checked = false;
            radio_hex.Checked = true;

            UpdateColorGUI();
        }

        private void radio_denary_Click(object sender, EventArgs e)
        {
            radio_binary.Checked = false;
            radio_hex.Checked = false;
            radio_denary.Checked = true;

            UpdateColorGUI();
        }

        private void help_Click(object sender, EventArgs e)
        {
            string message = @"Press File > New to create a blank canvas.

Use the radio buttons to change the format (hex, binary, deanary) of the pen colour.

Use sliders to change your pen color.

Use boxes Underneath to type in rgb value in hex/binary/deanary (whichever is selected).

If you seve as denary you must load as denary (same principals apply to denary and hex).
";

            MessageBox.Show(message, "How To use.");
        }

        private void UpdateColorGUI()
        {
            tb_r_Scroll(this, new EventArgs());
            tb_g_Scroll(this, new EventArgs());
            tb_b_Scroll(this, new EventArgs());

            pen_color_square.BackColor = penColor;
        }

        private void tb_r_Scroll(object sender, EventArgs e)
        {
            penColor = Color.FromArgb(255, tb_r.Value, penColor.G, penColor.B);
            pen_color_square.BackColor = penColor;
            textBox_r.Text = BaseNumberFromDenary(tb_r.Value);
        }

        private void tb_g_Scroll(object sender, EventArgs e)
        {
            penColor = Color.FromArgb(255, penColor.R, tb_g.Value, penColor.B);
            pen_color_square.BackColor = penColor;
            textBox_g.Text = BaseNumberFromDenary(tb_g.Value);
        }

        private void tb_b_Scroll(object sender, EventArgs e)
        {
            penColor = Color.FromArgb(255, penColor.R, penColor.G, tb_b.Value);
            pen_color_square.BackColor = penColor;
            textBox_b.Text = BaseNumberFromDenary(tb_b.Value);
        }

        private void textBox_r_TextChanged(object sender, EventArgs e)
        {
            TypeColor(textBox_r, 'r');
        }

        private void textBox_g_TextChanged(object sender, EventArgs e)
        {
            TypeColor(textBox_g, 'g');
        }

        private void textBox_b_TextChanged(object sender, EventArgs e)
        {
            TypeColor(textBox_b, 'b');
        }

        /// <summary>returns denary value as int depended on selection from radial buttons</summary> 
        private int GetDenaryValueInt(string stringValue)
        {
            // convert to denary
            int denary;

            if (radio_denary.Checked)
            {
                denary = int.Parse(stringValue);
            }
            else if (radio_binary.Checked)
            {
                Binary binary = new Binary(stringValue);
                denary = binary.DenaryValue;
            }
            else if (radio_hex.Checked)
            {
                Hex hex = new Hex(stringValue);
                denary = hex.DenaryValue;
            }
            else
            {
                throw new FormatException();
            }

            return denary;
        }

        /// <summary> gets hex/denary/binary from denary input</summary>
        private string BaseNumberFromDenary(int denary)
        {
            string baseNumber;

            if (radio_denary.Checked)
            {
                baseNumber = denary.ToString();
            }
            else if (radio_binary.Checked)
            {
                Binary binary = new Binary(denary);
                baseNumber = binary.Value;
            }
            else if (radio_hex.Checked)
            {
                Hex hex = new Hex(denary);
                baseNumber = hex.Value;
            }
            else
            {
                throw new FormatException();
            }

            return baseNumber;
        }


        /// <summary> chang one of rhe r g b values</summary>
        /// <param name="tb">text box that tries to change value</param>
        /// <param name="colorToChange">r g or b char</param>
        private void TypeColor(TextBox tb, char colorToChange)
        {
            // convert to denary
            int denary;

            try
            {
                denary = GetDenaryValueInt(tb.Text);
            }
            catch (FormatException)
            {
                // if in wrong form set text back to origional pen color
                //tb_r.Value = int.Parse(BaseNumberFromDenary(penColor.R));
                //tb_g.Value = int.Parse(BaseNumberFromDenary(penColor.G));
                //tb_b.Value = int.Parse(BaseNumberFromDenary(penColor.B));
                return;
            }

            // clamp denary between 0 and 255
            denary = Math.Min(255, denary);
            denary = Math.Max(0, denary);
            // set the color
            switch (colorToChange)
            {
                case 'r':
                    tb_r.Value = denary;
                    penColor = Color.FromArgb(255, denary, penColor.G, penColor.B);
                    break;
                case 'g':
                    tb_g.Value = denary;
                    penColor = Color.FromArgb(255, penColor.R, denary, penColor.B);
                    break;
                case 'b':
                    tb_b.Value = denary;
                    penColor = Color.FromArgb(255, penColor.R, penColor.G, denary);
                    break;
            }

            pen_color_square.BackColor = penColor;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void canvas_holder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox_always_on_top_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_always_on_top.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }
    }
}
