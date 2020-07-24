using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionProject
{
    public partial class CompareForm : Form
    {
        public CompareForm()
        {
            InitializeComponent();
            textBox1.Text = @"D:\UNI\testFiles\colourScale.jpg";
            textBox2.Text = @"D:\UNI\testFiles\CS4LSB.jpg";
        }

        public int FindDifference(int nr1, int nr2)
        {
            return Math.Abs(nr1 - nr2);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Bitmap imgOrig = new Bitmap(textBox1.Text);
            Bitmap imgSteg = new Bitmap(textBox2.Text);
            Bitmap imgDiff = new Bitmap(imgOrig.Width, imgOrig.Height);
            pictureBox1.Image = imgOrig;
            pictureBox2.Image = imgSteg;
            for (int y = 1; y < imgOrig.Height-1; y++)
            {
                for (int x = 1; x < imgOrig.Width-1; x++)
                {
                    Color pc1 = imgOrig.GetPixel(x, y);
                    Color pc2 = imgSteg.GetPixel(x, y);

                    int pc1Total = pc1.R + pc1.G + pc1.B;
                    int pc2Total = pc2.R + pc2.G + pc2.B;
                    int difference = FindDifference(pc1Total, pc2Total);
                    
                    Color diffCol = Color.FromArgb(difference, difference, difference);
                    imgDiff.SetPixel(x, y, diffCol);
                }
            }
            pictureBox3.Image = imgDiff;
            hintLabel.Text = "Images compared.";
        }

        private void openBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";
                open.InitialDirectory = @"C:\Users\User\Desktop\UNI\1920\productionProject\outputFiles";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = open.FileName.ToString();
                    pictureBox1.ImageLocation = open.FileName;
                    //get max potential length
                    Bitmap bmp = new Bitmap(textBox1.Text);
                }
            }

            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
            updateHint();
        }

        private void openBtn2_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";
                open.InitialDirectory = @"C:\Users\User\Desktop\UNI\1920\productionProject\outputFiles";
                if (open.ShowDialog() == DialogResult.OK)

                {
                    textBox2.Text = open.FileName.ToString();
                    pictureBox2.ImageLocation = open.FileName;
                    //get max potential length
                    Bitmap bmp = new Bitmap(textBox2.Text);
                }
            }

            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
            updateHint();
        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox3.Image);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.ImageLocation = saveFile.FileName.ToString();
                bmp.Save(saveFile.FileName.ToString());
                hintLabel.Text = "File saved.";
            }
        }

        private void updateHint()
        {
            if (pictureBox1 != null && pictureBox2 != null)
            {
                if(pictureBox1.Image == pictureBox2.Image)
                {
                    hintLabel.Text = "These images are equal sizes and can be compared.";
                }
                else
                {
                    hintLabel.Text = "These images are different sizes and should not be compared.";
                }
            }
            else
            {
                hintLabel.Text = "Please insert two images.";
            }
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

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
