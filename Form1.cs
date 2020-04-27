using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionProject
{
    public partial class Form1 : Form
    {
        StegoEmbedder embedder;
        StegoRetriever retriever;
        public Form1()
        {
            InitializeComponent();
            embedder = new StegoEmbedder();
            retriever = new StegoRetriever();
        }
        private void openButton_Click(object sender, EventArgs e)
        {

        }
        private void updateImgInfo(int length_)
        {
            //update 'image info' section
            Bitmap bmp = new Bitmap(routeBox.Text);
            Image img = Image.FromFile(routeBox.Text);
            ImageFormat format = img.RawFormat;
            //insert new text
            infoWidth.Text = "Width : " + img.Width;
            infoHeight.Text = "Height : " + img.Height;
            infoRes.Text = "Resolution : " + (img.VerticalResolution * img.HorizontalResolution);
            infoPixelDepth.Text = "Pixel depth : " + Image.GetPixelFormatSize(img.PixelFormat);
            infoStorage.Text = "optimal storage : " + length_;
        }
        private void embedButton_Click(object sender, EventArgs e)
        {
            if (Lsb1Button.Checked)
            {
                pictureBoxStego.Image = embedder.Embed1lsb(routeBox.Text, textToEmbed.Text);
            }
            else if (Lsb2Button.Checked)
            {
                pictureBoxStego.Image = embedder.Embed2lsb(routeBox.Text, textToEmbed.Text);
            }
            else if (Lsb3Button.Checked)
            {
                pictureBoxStego.Image = embedder.Embed3lsb(routeBox.Text, textToEmbed.Text);
            }
            else if (Lsb4Button.Checked)
            {
                pictureBoxStego.Image = embedder.Embed4lsb(routeBox.Text, textToEmbed.Text);
            }
        }


        private void saveStegoBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBoxStego.Image);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                stegobox.Text = saveFile.FileName.ToString();
                pictureBoxStego.ImageLocation = stegobox.Text;
                bmp.Save(stegobox.Text);

            }
        }
        private void textToEmbed_TextChanged(object sender, EventArgs e)
        {
            lengthLabel.Text = "Length: " + textToEmbed.TextLength;
        }

        private void decodedText_TextChanged(object sender, EventArgs e)
        {
            stegoLengthLabel.Text = "Length: " + decodedText.TextLength;
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
                    pictureBoxInput.ImageLocation = open.FileName;
                    //get max potential length
                    Bitmap bmp = new Bitmap(routeBox.Text);
                    int length = (bmp.Width * bmp.Height); //-1 for the final pixel which stores the length.
                    textToEmbed.MaxLength = length;
                    //update info panel
                    updateImgInfo(length);
                }
            }

            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }
        private void saveButton_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBoxInput.Image);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                routeBox.Text = saveFile.FileName.ToString();
                pictureBoxInput.ImageLocation = routeBox.Text;
                bmp.Save(routeBox.Text);

            }
        }
        private void openStegoBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";
                open.InitialDirectory = @"C:\Users\User\Desktop\UNI\1920\productionProject\outputFiles";
                if (open.ShowDialog() == DialogResult.OK)

                {
                    stegobox.Text = open.FileName.ToString();
                    pictureBoxStego.ImageLocation = open.FileName;
                }
            }

            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }
        private void saveStegoBtn_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBoxStego.Image);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                stegobox.Text = saveFile.FileName.ToString();
                pictureBoxStego.ImageLocation = stegobox.Text;
                bmp.Save(stegobox.Text);

            }
        }

        private void decodeButton_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(stegobox.Text))
            {
                if (Lsb1Button.Checked)
                {
                    decodedText.Text = retriever.Retrieve1lsb(stegobox.Text);
                }
                else if (Lsb2Button.Checked)
                {
                    decodedText.Text = retriever.Retrieve2lsb(stegobox.Text);
                }
                else if (Lsb3Button.Checked)
                {
                    decodedText.Text = retriever.Retrieve3lsb(stegobox.Text);
                }
                else if (Lsb4Button.Checked)
                {
                    decodedText.Text = retriever.Retrieve4lsb(stegobox.Text);
                }

                stegoLengthLabel.Text = "Length: " + decodedText.TextLength;
            }
            else
            {
                MessageBox.Show("No path specified, please assign a path using the textbox or 'open...' button");
            }
        }
    }
}