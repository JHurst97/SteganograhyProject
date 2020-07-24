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
    public partial class WelcomeForm : Form
    {

        TextEmbedForm embedForm = new TextEmbedForm();
        ImageEmbedderForm imgEmbedForm = new ImageEmbedderForm();
        CompareForm compareForm = new CompareForm();
        AboutForm aboutForm = new AboutForm();

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            embedForm.ShowDialog();
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will destroy any unsaved work and close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.GetCurrentProcess().Kill();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            compareForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            imgEmbedForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aboutForm.ShowDialog();
        }
    }
}
