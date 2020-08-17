using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionProject
{
    class ImageExtractor
    {

        Bitmap finalIMG;
        Operations ops = new Operations();
        public Bitmap Retrieve1lsb(string inRoute_)
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
            Color SLastPixel = bmp.GetPixel(bmp.Width - 2, bmp.Height - 1);
            int width = SLastPixel.G;
            int height = SLastPixel.B;
            //length in decimal
            long msgLength = ops.binaryToDecimalLong(finalLength);

            //DECODING 
            string message = "";
            int counter = 0;

            while (counter < msgLength)
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

            //convert bitstring(message) back to image
            finalIMG = new Bitmap(width, height);
            for (int y = 0; y < finalIMG.Height; y++)
            {
                for (int x = 0; x < finalIMG.Width; x++)
                {

                    int r = 0;
                    int g = 0;
                    int b = 0;
                    //rgb
                    for (int i = 0; i < 3; i++)
                    {
                        switch (i)
                        {
                            //R
                            case 0:
                                {

                                    int newR = Convert.ToInt32(message.Substring(0, 8));

                                    //remove first digit message(bitstring)
                                    message = message.Substring(8, message.Length - 8);

                                    r = ops.binaryToDecimal(newR);

                                    break;
                                }
                            //G
                            case 1:
                                {
                                    int newG = Convert.ToInt32(message.Substring(0, 8));

                                    //remove first digit message(bitstring)
                                    message = message.Substring(8, message.Length - 8);

                                    g = ops.binaryToDecimal(newG);

                                    break;
                                }
                            //B
                            case 2:
                                {
                                    int newB = Convert.ToInt32(message.Substring(0, 8));

                                    //remove first digit message(bitstring)
                                    message = message.Substring(8, message.Length - 8);

                                    b = ops.binaryToDecimal(newB);

                                    break;
                                }

                        }

                    }

                    Color colIn = Color.FromArgb(r, g, b);
                    finalIMG.SetPixel(x, y, colIn);
                }
            }


            //update textbox with decoded
            return finalIMG;
            //update image info panel
            // updateImgInfo();
        }

        //2 LSB

        public Bitmap Retrieve2lsb(string inRoute_)
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
            Color SLastPixel = bmp.GetPixel(bmp.Width - 2, bmp.Height - 1);
            int width = SLastPixel.G;
            int height = SLastPixel.B;
            //length in decimal
            long msgLength = ops.binaryToDecimalLong(finalLength);

            //DECODING 
            string message = "";
            int counter = 0;

            while (counter < msgLength)
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

            //convert bitstring(message) back to image
            finalIMG = new Bitmap(width, height);
            for (int y = 0; y < finalIMG.Height; y++)
            {
                for (int x = 0; x < finalIMG.Width; x++)
                {

                    int r = 0;
                    int g = 0;
                    int b = 0;
                    //rgb
                    for (int i = 0; i < 3; i++)
                    {
                        switch (i)
                        {
                            //R
                            case 0:
                                {

                                    int newR = Convert.ToInt32(message.Substring(0, 8));

                                    //remove first digit message(bitstring)
                                    message = message.Substring(8, message.Length - 8);

                                    r = ops.binaryToDecimal(newR);

                                    break;
                                }
                            //G
                            case 1:
                                {
                                    int newG = Convert.ToInt32(message.Substring(0, 8));

                                    //remove first digit message(bitstring)
                                    message = message.Substring(8, message.Length - 8);

                                    g = ops.binaryToDecimal(newG);

                                    break;
                                }
                            //B
                            case 2:
                                {
                                    int newB = Convert.ToInt32(message.Substring(0, 8));

                                    //remove first digit message(bitstring)
                                    message = message.Substring(8, message.Length - 8);

                                    b = ops.binaryToDecimal(newB);

                                    break;
                                }

                        }

                    }

                    Color colIn = Color.FromArgb(r, g, b);
                    finalIMG.SetPixel(x, y, colIn);
                }
            }


            //update textbox with decoded
            return finalIMG;
            //update image info panel
            // updateImgInfo();
        }

        //3 LSB

        public Bitmap Retrieve3lsb(string inRoute_)
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
            Color SLastPixel = bmp.GetPixel(bmp.Width - 2, bmp.Height - 1);
            int width = SLastPixel.G;
            int height = SLastPixel.B;
            //length in decimal
            long msgLength = ops.binaryToDecimalLong(finalLength);

            //DECODING 
            string message = "";
            int counter = 0;

            while (counter < msgLength)
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

            //convert bitstring(message) back to image
            finalIMG = new Bitmap(width, height);
            for (int y = 0; y < finalIMG.Height; y++)
            {
                for (int x = 0; x < finalIMG.Width; x++)
                {

                    int r = 0;
                    int g = 0;
                    int b = 0;
                    //rgb
                    for (int i = 0; i < 3; i++)
                    {
                        switch (i)
                        {
                            //R
                            case 0:
                                {

                                    int newR = Convert.ToInt32(message.Substring(0, 8));

                                    //remove first digit message(bitstring)
                                    message = message.Substring(8, message.Length - 8);

                                    r = ops.binaryToDecimal(newR);

                                    break;
                                }
                            //G
                            case 1:
                                {
                                    int newG = Convert.ToInt32(message.Substring(0, 8));

                                    //remove first digit message(bitstring)
                                    message = message.Substring(8, message.Length - 8);

                                    g = ops.binaryToDecimal(newG);

                                    break;
                                }
                            //B
                            case 2:
                                {
                                    int newB = Convert.ToInt32(message.Substring(0, 8));

                                    //remove first digit message(bitstring)
                                    message = message.Substring(8, message.Length - 8);

                                    b = ops.binaryToDecimal(newB);

                                    break;
                                }

                        }

                    }

                    Color colIn = Color.FromArgb(r, g, b);
                    finalIMG.SetPixel(x, y, colIn);
                }
            }


            //update textbox with decoded
            return finalIMG;
            //update image info panel
            // updateImgInfo();
        }

        //4 LSB

        public Bitmap Retrieve4lsb(string inRoute_)
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
            Color SLastPixel = bmp.GetPixel(bmp.Width - 2, bmp.Height - 1);
            int width = SLastPixel.G;
            int height = SLastPixel.B;
            //length in decimal
            long msgLength = ops.binaryToDecimalLong(finalLength);

            //DECODING 
            string message = "";
            int counter = 0;

            while (counter < msgLength)
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

            //convert bitstring(message) back to image
            finalIMG = new Bitmap(width, height);
            for (int y = 0; y < finalIMG.Height; y++)
            {
                for (int x = 0; x < finalIMG.Width; x++)
                {

                    int r = 0;
                    int g = 0;
                    int b = 0;
                    //rgb
                    for (int i = 0; i < 3; i++)
                    {
                        switch (i)
                        {
                            //R
                            case 0:
                                {

                                    int newR = Convert.ToInt32(message.Substring(0, 8));

                                    //remove first digit message(bitstring)
                                    message = message.Substring(8, message.Length - 8);

                                    r = ops.binaryToDecimal(newR);

                                    break;
                                }
                            //G
                            case 1:
                                {
                                    int newG = Convert.ToInt32(message.Substring(0, 8));

                                    //remove first digit message(bitstring)
                                    message = message.Substring(8, message.Length - 8);

                                    g = ops.binaryToDecimal(newG);

                                    break;
                                }
                            //B
                            case 2:
                                {
                                    int newB = Convert.ToInt32(message.Substring(0, 8));

                                    //remove first digit message(bitstring)
                                    message = message.Substring(8, message.Length - 8);

                                    b = ops.binaryToDecimal(newB);

                                    break;
                                }

                        }

                    }

                    Color colIn = Color.FromArgb(r, g, b);
                    finalIMG.SetPixel(x, y, colIn);
                }
            }


            //update textbox with decoded
            return finalIMG;
            //update image info panel
            // updateImgInfo();
        }


    }
}
