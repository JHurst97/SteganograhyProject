using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionProject
{
    class StegoRetriever
    {
        Operations ops = new Operations();

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
            string currentLetter = "";
            string message = "";
            int counter = 0;
            while (counter < msgLength * 8)
            {
                Color pixelCol = bmp.GetPixel(pixelIndex.Y, pixelIndex.X);
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
                pixelIndex.Y++;
                if (pixelIndex.Y > bmp.Height)
                {
                    pixelIndex.Y = 0;
                    pixelIndex.X++;
                }
            }


            //update textbox with decoded
            return ops.BinaryToString(message);
            //update image info panel
            // updateImgInfo();
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
            long msgLength = ops.binaryToDecimalLong(finalLength);

            //DECODING 
            string currentLetter = "";
            string message = "";
            int counter = 0;
            while (counter < msgLength * 8)
            {
                Color pixelCol = bmp.GetPixel(pixelIndex.Y, pixelIndex.X);
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
                pixelIndex.Y++;
                if (pixelIndex.Y > bmp.Height)
                {
                    pixelIndex.Y = 0;
                    pixelIndex.X++;
                }
            }


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
            long msgLength = ops.binaryToDecimalLong(finalLength);

            //DECODING 
            string currentLetter = "";
            string message = "";
            int counter = 0;
            while (counter < msgLength * 8)
            {
                Color pixelCol = bmp.GetPixel(pixelIndex.Y, pixelIndex.X);
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
                pixelIndex.Y++;
                if (pixelIndex.Y > bmp.Height)
                {
                    pixelIndex.Y = 0;
                    pixelIndex.X++;
                }
            }


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

            for (int i = 0; i < msgLength; i++)
            {
                Color pixelCol = bmp.GetPixel(pixelIndex.Y, pixelIndex.X);
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
                pixelIndex.Y++;
                if (pixelIndex.Y > bmp.Height)
                {
                    pixelIndex.Y = 0;
                    pixelIndex.X++;
                }

            }

            //update textbox with decoded
            return ops.BinaryToString(message);
            //update image info panel
            // updateImgInfo();
        }

    }
}