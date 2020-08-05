using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionProject
{
    public partial class ImageEmbedderForm : Form
    {
        ImageEmbedder ie = new ImageEmbedder();
        ImageExtractor ix = new ImageExtractor();

        public ImageEmbedderForm()
        {
            InitializeComponent();
            extractPanel.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //make window draggable (after removing border)
        private bool mouseDown;
        private Point lastLocation;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }






        private void button1_Click(object sender, EventArgs e)
        {
            extractPanel.Visible = false;
            this.Size = new Size(740, 732);
            embedPanel.Visible = true;
            embedBtn.BackColor = Color.White;
            extractBtn.BackColor = Color.DimGray;
        }

        private void extractBtn_Click(object sender, EventArgs e)
        {
            embedPanel.Visible = false;
            this.Size = new Size(650, 450);
            extractPanel.Visible = true;
            embedBtn.BackColor = Color.DimGray;
            extractBtn.BackColor = Color.White;
        }

        private void embedButton_Click_1(object sender, EventArgs e)
        {
            //check for errors
            if (routeBox.Text == "")
            {
                MessageBox.Show("ERROR: no cover image selected, see 'cover image' section.");
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("ERROR: no input image selected, see 'image to embed' section.");
            }

            //sw and different LSBs.
            else if (Lsb1Button.Checked)
            {
                pictureBox3.Image = ie.Embed1lsb(routeBox.Text, textBox1.Text);
            }
            else if (Lsb4Button.Checked)
            {
                pictureBox3.Image = ie.Embed4lsb(routeBox.Text, textBox1.Text);
            }

        }

        private void openButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";
                open.InitialDirectory = @"C:\Users\User\Desktop\UNI\1920\productionProject\outputFiles";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    routeBox.Text = open.FileName.ToString();
                    pictureBox1.ImageLocation = open.FileName;
                    //get max potential length
                    Bitmap bmp = new Bitmap(routeBox.Text);
                }
            }

            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void openButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";
                open.InitialDirectory = @"C:\Users\User\Desktop\UNI\1920\productionProject\outputFiles";
                if (open.ShowDialog() == DialogResult.OK)

                {
                    textBox1.Text = open.FileName.ToString();
                    pictureBox2.ImageLocation = open.FileName;
                    //get max potential length
                    Bitmap bmp = new Bitmap(textBox1.Text);
                }
            }

            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox3.Image);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = saveFile.FileName.ToString();
                bmp.Save(textBox2.Text);
                saveFile.Dispose();
            }
        }

        private void decodeButton_Click_1(object sender, EventArgs e)
        {
            //check for errors
            if (textBox2.Text == "" && extractPanel.Visible == true)
            {
                MessageBox.Show("ERROR: no target file selected, see 'target file' section.");
            }
            else
            {
                pictureBox4.Image = new Bitmap(textBox2.Text);
                pictureBox5.Image = ix.Retrieve1lsb(textBox2.Text);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox5.Image);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string route = saveFile.FileName.ToString();
                saveLabel.Text = route;
                pictureBox5.ImageLocation = saveLabel.Text;
                bmp.Save(route);
                bmp.Dispose();
                saveFile.Dispose();
            }
        }
    }
}