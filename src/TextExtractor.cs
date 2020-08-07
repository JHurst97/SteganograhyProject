using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionProject
{
    class TextExtractor
    {
        Operations ops = new Operations();
        private ProgressBar pBar1;

        public TextExtractor(ProgressBar pBar1)
        {
            this.pBar1 = pBar1;
            pBar1.Visible = false;
        }

        public string Retrieve1lsb(string inRoute_)
        {
            Point pixelIndex = new Point(1, 0);
            Bitmap bmp = new Bitmap(inRoute_);

            //get length from final pixel
            Color lastPixel = bmp.GetPixel(bmp.Width - 1, bmp.Height - 1);
            string first = ops.convNumberToBits(lastPixel.R);
            string second = ops.convNumberToBits(lastPixel.G);
            string third = ops.convNumberToBits(lastPixel.B);
            string concat = first + second + third;
            long finalLength = Convert.ToInt64(concat);

            //length in decimal
            long msgLength = ops.binaryToDecimalLong(finalLength);

            //DECODING 
            string message = "";
            int counter = 0;
            //progress bar
            pBarSetup(msgLength * 8);

            while (counter < msgLength * 8)
            {
                //increase progress bar
                pBar1.PerformStep();
                Color pixelCol = bmp.GetPixel(pixelIndex.X, pixelIndex.Y);
                //loop through R/G/B
                for (int rgb = 0; rgb < 3; rgb++)
                {
                    if (counter < msgLength * 8)
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    //get the binary values of R (notice the "2" param)
                                    string rBitString = ops.convNumberToBits(pixelCol.R);
                                    //get last 4 digits of letter (which is the first 4 digits of our letter)
                                    string rLastFour = rBitString.Substring(7, 1);

                                    message += rLastFour;
                                    counter++;
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    //get the binary values of G
                                    string gBitString = ops.convNumberToBits(pixelCol.G);
                                    //get first 4 digit of G
                                    string gLastFour = gBitString.Substring(7, 1);
                                    message += gLastFour;
                                    counter++;
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    //get the binary values of B
                                    string bBitString = ops.convNumberToBits(pixelCol.B);
                                    //get first 4 digit of B
                                    string bLastFour = bBitString.Substring(7, 1);
                                    message += bLastFour;
                                    counter++;
                                    break;
                                }

                        }
                    }

                }
                pixelIndex.X++;
                if (pixelIndex.X >= bmp.Width)
                {
                    pixelIndex.X = 1;
                    pixelIndex.Y++;
                }
            }

            pBar1.Visible = false;
            //update textbox with decoded
            return ops.BinaryToString(message);
            //update image info panel
            // updateImgInfo();
        }

        private void pBarSetup(long inLength_)
        {
            //Convert long to int for maximum
            int length = Convert.ToInt32(inLength_);
            // Display the ProgressBar control.
            pBar1.Visible = true;
            // Set Minimum to 1 to represent the first file being copied.
            pBar1.Minimum = 1;
            // Set Maximum to the total number of files to copy.
            pBar1.Maximum = length;
            // Set the initial value of the ProgressBar.
            pBar1.Value = 1;
            // Set the Step property to a value of 1 to represent each file being copied.
            pBar1.Step = 1;
        }

        public string Retrieve2lsb(string inRoute_)
        {
            Point pixelIndex = new Point(1, 0);
            Bitmap bmp = new Bitmap(inRoute_);

            //get length from final pixel
            Color lastPixel = bmp.GetPixel(bmp.Width - 1, bmp.Height - 1);
            string first = ops.convNumberToBits(lastPixel.R);
            string second = ops.convNumberToBits(lastPixel.G);
            string third = ops.convNumberToBits(lastPixel.B);
            string concat = first + second + third;
            long finalLength = Convert.ToInt64(concat);

            //length in decimal
            long msgLength = ops.binaryToDecimalLong(finalLength) /2;

            //DECODING 
            string currentLetter = "";
            string message = "";
            int counter = 0;
            pBarSetup(msgLength * 8);
            while (counter < msgLength * 8)
            {
                //increase progress bar
                pBar1.PerformStep();
                Color pixelCol = bmp.GetPixel(pixelIndex.X, pixelIndex.Y);
                //loop through R/G/B
                for (int rgb = 0; rgb < 3; rgb++)
                {
                    if (counter < msgLength * 8)
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    //get the binary values of R (notice the "2" param)
                                    string rBitString = ops.convNumberToBits(pixelCol.R);
                                    //get last 4 digits of letter (which is the first 4 digits of our letter)
                                    string rLastFour = rBitString.Substring(6, 2);

                                    message += rLastFour;
                                    counter++;
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    //get the binary values of G
                                    string gBitString = ops.convNumberToBits(pixelCol.G);
                                    //get first 4 digit of G
                                    string gLastFour = gBitString.Substring(6, 2);
                                    message += gLastFour;
                                    counter++;
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    //get the binary values of B
                                    string bBitString = ops.convNumberToBits(pixelCol.B);
                                    //get first 4 digit of B
                                    string bLastFour = bBitString.Substring(6, 2);
                                    message += bLastFour;
                                    counter++;
                                    break;
                                }

                        }
                    }

                }
                pixelIndex.X++;
                if (pixelIndex.X >= bmp.Width)
                {
                    pixelIndex.X = 1;
                    pixelIndex.Y++;
                }
            }

            pBar1.Visible = false;
            //update textbox with decoded
            return ops.BinaryToString(message);
            //update image info panel
            // updateImgInfo();
        }
        public string Retrieve3lsb(string inRoute_)
        {
            Point pixelIndex = new Point(1, 0);
            Bitmap bmp = new Bitmap(inRoute_);

            //get length from final pixel
            Color lastPixel = bmp.GetPixel(bmp.Width - 1, bmp.Height - 1);
            string first = ops.convNumberToBits(lastPixel.R);
            string second = ops.convNumberToBits(lastPixel.G);
            string third = ops.convNumberToBits(lastPixel.B);
            string concat = first + second + third;
            long finalLength = Convert.ToInt64(concat);

            //length in decimal
            long msgLength = ops.binaryToDecimalLong(finalLength) /3;

            //DECODING 
            string message = "";
            int counter = 0;
            pBarSetup(msgLength * 8);
            while (counter < msgLength * 8)
            {
                //increase progress bar
                pBar1.PerformStep();
                Color pixelCol = bmp.GetPixel(pixelIndex.X, pixelIndex.Y);
                //loop through R/G/B
                for (int rgb = 0; rgb < 3; rgb++)
                {
                    if (counter < msgLength * 8)
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    //get the binary values of R (notice the "2" param)
                                    string rBitString = ops.convNumberToBits(pixelCol.R);
                                    //get last 4 digits of letter (which is the first 4 digits of our letter)
                                    string rLastFour = rBitString.Substring(5, 3);

                                    message += rLastFour;
                                    counter++;
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    //get the binary values of G
                                    string gBitString = ops.convNumberToBits(pixelCol.G);
                                    //get first 4 digit of G
                                    string gLastFour = gBitString.Substring(5, 3);
                                    message += gLastFour;
                                    counter++;
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    //get the binary values of B
                                    string bBitString = ops.convNumberToBits(pixelCol.B);
                                    //get first 4 digit of B
                                    string bLastFour = bBitString.Substring(5, 3);
                                    message += bLastFour;
                                    counter++;
                                    break;
                                }

                        }
                    }

                }

                pixelIndex.X++;
                if (pixelIndex.X >= bmp.Width - 1)
                {
                    pixelIndex.X = 1;
                    pixelIndex.Y++;
                }


            }

            pBar1.Visible = false;
            //update textbox with decoded
            return ops.BinaryToString(message);
            //update image info panel
            // updateImgInfo();
        }
        public string Retrieve4lsb(string inRoute_)
        {
            Point pixelIndex = new Point(1, 0);
            Bitmap bmp = new Bitmap(inRoute_);

            //get length from final pixel
            Color lastPixel = bmp.GetPixel(bmp.Width - 1, bmp.Height - 1);
            string first = ops.convNumberToBits(lastPixel.R);
            string second = ops.convNumberToBits(lastPixel.G);
            string third = ops.convNumberToBits(lastPixel.B);
            string concat = first + second + third;
            long finalLength = Convert.ToInt64(concat);

            //length in decimal
            long msgLength = ops.binaryToDecimalLong(finalLength);

            //DECODING 
            string currentLetter = "";
            string message = "";
            pBarSetup(msgLength * 8);
            for (int i = 0; i < msgLength; i++)
            {
                //increase progress bar
                pBar1.PerformStep();
                Color pixelCol = bmp.GetPixel(pixelIndex.X, pixelIndex.Y);
                //loop through R/G/B
                for (int rgb = 0; rgb < 2; rgb++)
                {
                    switch (rgb)
                    {
                        //R
                        case 0:
                            {
                                //get the binary values of R (notice the "2" param)
                                string rBitString = ops.convNumberToBits(pixelCol.R);
                                //get last 4 digits of letter (which is the first 4 digits of our letter)
                                string rLastFour = ops.removeFromStart(rBitString, 4);

                                currentLetter = rLastFour;
                                message += rLastFour;
                                break;
                            }
                        //G
                        case 1:
                            {
                                //get the binary values of G
                                string gBitString = ops.convNumberToBits(pixelCol.G);
                                //get first 4 digit of G
                                string gLastFour = ops.removeFromStart(gBitString, 4);
                                currentLetter += gLastFour;
                                message += gLastFour;
                                break;
                            }

                    }
                }
                pixelIndex.X++;
                if (pixelIndex.X >= bmp.Width)
                {
                    pixelIndex.X = 0;
                    pixelIndex.Y++;
                }

            }
            pBar1.Visible = false;
            //update textbox with decoded
            return ops.BinaryToString(message);
            //update image info panel
            // updateImgInfo();
        }

    }
}