using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionProject
{
    class ImageEmbedder
    {


        Operations ops = new Operations();
        Bitmap bmpCover;
        Bitmap bmpStego;

        public Bitmap Embed1lsb(string coverRoute_, string stegoRoute_)
        {
            bmpCover = new Bitmap(coverRoute_);
            bmpStego = new Bitmap(stegoRoute_);
            string bitString = "";
            Point pixelIndex = new Point(1, 0);
            //width * height * 8 * 3
            SetLength((bmpStego.Width * bmpStego.Height) * 24);
            //set width and height in second to last pixel
            SetWH(bmpStego.Width, bmpStego.Height);


            //convert image to bitstring.
            for (int y = 0; y < bmpStego.Height; y++)
            {
                for (int x = 0; x < bmpStego.Width; x++)
                {

                    Color pixelCol = bmpStego.GetPixel(x, y);

                    for (int rgb = 0; rgb < 3; rgb++)
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    //get the binary value of current letter in message
                                    string newBit = ops.convNumberToBits(pixelCol.R);
                                    //append bitstream with new byte
                                    bitString = bitString + newBit;
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    //get the binary value of current letter in message
                                    string newBit = ops.convNumberToBits(pixelCol.G);
                                    //append bitstream with new byte
                                    bitString = bitString + newBit;
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    //get the binary value of current letter in message
                                    string newBit = ops.convNumberToBits(pixelCol.B);
                                    //append bitstream with new byte
                                    bitString = bitString + newBit;
                                    break;
                                }
                        }
                    }


                }
            }

            //calculate how many pixels are needed 
            int noOfPixels = (int)bitString.Length / 3;


            //for each pixel in image.
            for (int i = 0; i < noOfPixels; i++)
            {

                //retrieve pixel at index
                Color pixelCol = bmpCover.GetPixel(pixelIndex.Y, pixelIndex.X);

                int finalR = 0, finalG = 0, finalB = 0;
                //loop through R/G/B of pixel
                for (int rgb = 0; rgb < 3; rgb++)
                {
                    if (!String.IsNullOrEmpty(bitString))
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    //get the binary values of R 
                                    string rBitString = ops.convNumberToBits(pixelCol.R);
                                    //get first 7 digit of R
                                    string rFirstFour = rBitString.Substring(0, 7);
                                    //get first digit from bitStream
                                    string lFirstFour = bitString.Substring(0, 1);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    //merge and convert to back to int
                                    int newR = Convert.ToInt32(rFirstFour + lFirstFour);

                                    finalR = ops.binaryToDecimal(newR);
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    //get the binary values of G
                                    string gBitString = ops.convNumberToBits(pixelCol.G);
                                    //get first 7 digit of G
                                    string gFirstFour = gBitString.Substring(0, 7);
                                    //get first digit from bitStream
                                    string lLastFour = bitString.Substring(0, 1);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    //merge 
                                    int newG = Convert.ToInt32(gFirstFour + lLastFour);

                                    finalG = ops.binaryToDecimal(newG);
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    //get the binary values of B
                                    string bBitString = ops.convNumberToBits(pixelCol.B);
                                    //get first 7 digit of B
                                    string bFirstFour = bBitString.Substring(0, 7);
                                    //get first digit from bitStream
                                    string lLastFour = bitString.Substring(0, 1);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    //merge 
                                    int newB = Convert.ToInt32(bFirstFour + lLastFour);

                                    finalB = ops.binaryToDecimal(newB);
                                    break;
                                }
                        }
                    }
                }
                bmpCover.SetPixel(pixelIndex.Y, pixelIndex.X, Color.FromArgb(finalR, finalG, finalB));

                pixelIndex.Y++;
                if (pixelIndex.Y > bmpCover.Height)
                {
                    pixelIndex.Y = 0;
                    pixelIndex.X++;
                }
            }
            return bmpCover;
        }

        public Bitmap Embed2lsb(string coverRoute_, string stegoRoute_)
        {
            bmpCover = new Bitmap(coverRoute_);
            bmpStego = new Bitmap(stegoRoute_);
            string bitString = "";
            Point pixelIndex = new Point(1, 0);
            //width * height * 8 * 3
            SetLength((bmpStego.Width * bmpStego.Height) * 24);
            //set width and height in second to last pixel
            SetWH(bmpStego.Width, bmpStego.Height);


            //convert image to bitstring.
            for (int y = 0; y < bmpStego.Height; y++)
            {
                for (int x = 0; x < bmpStego.Width; x++)
                {

                    Color pixelCol = bmpStego.GetPixel(x, y);

                    for (int rgb = 0; rgb < 3; rgb++)
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    //get the binary value of current letter in message
                                    string newBit = ops.convNumberToBits(pixelCol.R);
                                    //append bitstream with new byte
                                    bitString = bitString + newBit;
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    //get the binary value of current letter in message
                                    string newBit = ops.convNumberToBits(pixelCol.G);
                                    //append bitstream with new byte
                                    bitString = bitString + newBit;
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    //get the binary value of current letter in message
                                    string newBit = ops.convNumberToBits(pixelCol.B);
                                    //append bitstream with new byte
                                    bitString = bitString + newBit;
                                    break;
                                }
                        }
                    }


                }
            }

            //calculate how many pixels are needed 
            int noOfPixels = (int)(bitString.Length / 3) / 2;


            //for each pixel in image.
            for (int i = 0; i < noOfPixels; i++)
            {

                //retrieve pixel at index
                Color pixelCol = bmpCover.GetPixel(pixelIndex.Y, pixelIndex.X);

                int finalR = 0, finalG = 0, finalB = 0;
                //loop through R/G/B of pixel
                for (int rgb = 0; rgb < 3; rgb++)
                {
                    if (!String.IsNullOrEmpty(bitString))
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    //get the binary values of R 
                                    string rBitString = ops.convNumberToBits(pixelCol.R);
                                    //get first 7 digit of R
                                    string rFirstFour = rBitString.Substring(0, 6);
                                    //get first digit from bitStream
                                    string lFirstFour = bitString.Substring(0, 2);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    //merge and convert to back to int
                                    int newR = Convert.ToInt32(rFirstFour + lFirstFour);

                                    finalR = ops.binaryToDecimal(newR);
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    //get the binary values of G
                                    string gBitString = ops.convNumberToBits(pixelCol.G);
                                    //get first 7 digit of G
                                    string gFirstFour = gBitString.Substring(0, 6);
                                    //get first digit from bitStream
                                    string lLastFour = bitString.Substring(0, 2);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    //merge 
                                    int newG = Convert.ToInt32(gFirstFour + lLastFour);

                                    finalG = ops.binaryToDecimal(newG);
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    //get the binary values of B
                                    string bBitString = ops.convNumberToBits(pixelCol.B);
                                    //get first 7 digit of B
                                    string bFirstFour = bBitString.Substring(0, 6);
                                    //get first digit from bitStream
                                    string lLastFour = bitString.Substring(0, 2);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    //merge 
                                    int newB = Convert.ToInt32(bFirstFour + lLastFour);

                                    finalB = ops.binaryToDecimal(newB);
                                    break;
                                }
                        }
                    }
                }
                bmpCover.SetPixel(pixelIndex.Y, pixelIndex.X, Color.FromArgb(finalR, finalG, finalB));

                pixelIndex.Y++;
                if (pixelIndex.Y > bmpCover.Height)
                {
                    pixelIndex.Y = 0;
                    pixelIndex.X++;
                }
            }
            return bmpCover;
        }

        public Bitmap Embed3lsb(string coverRoute_, string stegoRoute_)
        {
            bmpCover = new Bitmap(coverRoute_);
            bmpStego = new Bitmap(stegoRoute_);
            string bitString = "";
            Point pixelIndex = new Point(1, 0);
            //width * height * 8 * 3
            SetLength((bmpStego.Width * bmpStego.Height) * 24);
            //set width and height in second to last pixel
            SetWH(bmpStego.Width, bmpStego.Height);


            //convert image to bitstring.
            for (int y = 0; y < bmpStego.Height; y++)
            {
                for (int x = 0; x < bmpStego.Width; x++)
                {

                    Color pixelCol = bmpStego.GetPixel(x, y);

                    for (int rgb = 0; rgb < 3; rgb++)
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    //get the binary value of current letter in message
                                    string newBit = ops.convNumberToBits(pixelCol.R);
                                    //append bitstream with new byte
                                    bitString = bitString + newBit;
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    //get the binary value of current letter in message
                                    string newBit = ops.convNumberToBits(pixelCol.G);
                                    //append bitstream with new byte
                                    bitString = bitString + newBit;
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    //get the binary value of current letter in message
                                    string newBit = ops.convNumberToBits(pixelCol.B);
                                    //append bitstream with new byte
                                    bitString = bitString + newBit;
                                    break;
                                }
                        }
                    }


                }
            }

            //calculate how many pixels are needed 
            int noOfPixels = (int)(bitString.Length / 3) / 3;


            //for each pixel in image.
            for (int i = 0; i < noOfPixels; i++)
            {

                //retrieve pixel at index
                Color pixelCol = bmpCover.GetPixel(pixelIndex.Y, pixelIndex.X);

                int finalR = 0, finalG = 0, finalB = 0;
                //loop through R/G/B of pixel
                for (int rgb = 0; rgb < 3; rgb++)
                {
                    if (!String.IsNullOrEmpty(bitString))
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    //get the binary values of R 
                                    string rBitString = ops.convNumberToBits(pixelCol.R);
                                    //get first 7 digit of R
                                    string rFirstFour = rBitString.Substring(0, 5);
                                    //get first digit from bitStream
                                    string lFirstFour = bitString.Substring(0, 3);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    //merge and convert to back to int
                                    int newR = Convert.ToInt32(rFirstFour + lFirstFour);

                                    finalR = ops.binaryToDecimal(newR);
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    //get the binary values of G
                                    string gBitString = ops.convNumberToBits(pixelCol.G);
                                    //get first 7 digit of G
                                    string gFirstFour = gBitString.Substring(0, 5);
                                    //get first digit from bitStream
                                    string lLastFour = bitString.Substring(0, 3);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    //merge 
                                    int newG = Convert.ToInt32(gFirstFour + lLastFour);

                                    finalG = ops.binaryToDecimal(newG);
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    //get the binary values of B
                                    string bBitString = ops.convNumberToBits(pixelCol.B);
                                    //get first 7 digit of B
                                    string bFirstFour = bBitString.Substring(0, 5);
                                    //get first digit from bitStream
                                    string lLastFour = bitString.Substring(0, 3);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    //merge 
                                    int newB = Convert.ToInt32(bFirstFour + lLastFour);

                                    finalB = ops.binaryToDecimal(newB);
                                    break;
                                }
                        }
                    }
                }
                bmpCover.SetPixel(pixelIndex.Y, pixelIndex.X, Color.FromArgb(finalR, finalG, finalB));

                pixelIndex.Y++;
                if (pixelIndex.Y > bmpCover.Height)
                {
                    pixelIndex.Y = 0;
                    pixelIndex.X++;
                }
            }
            return bmpCover;
        }

        public Bitmap Embed4lsb(string coverRoute_, string stegoRoute_)
        {
            bmpCover = new Bitmap(coverRoute_);
            bmpStego = new Bitmap(stegoRoute_);
            string bitString = "";
            Point pixelIndex = new Point(1, 0);
            //width * height * 8 * 3
            SetLength((bmpStego.Width * bmpStego.Height) * 24);
            //set width and height in second to last pixel
            SetWH(bmpStego.Width, bmpStego.Height);


            //convert image to bitstring.
            for (int y = 0; y < bmpStego.Height; y++)
            {
                for (int x = 0; x < bmpStego.Width; x++)
                {

                    Color pixelCol = bmpStego.GetPixel(x, y);

                    for (int rgb = 0; rgb < 3; rgb++)
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    //get the binary value of current letter in message
                                    string newBit = ops.convNumberToBits(pixelCol.R);
                                    //append bitstream with new byte
                                    bitString = bitString + newBit;
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    //get the binary value of current letter in message
                                    string newBit = ops.convNumberToBits(pixelCol.G);
                                    //append bitstream with new byte
                                    bitString = bitString + newBit;
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    //get the binary value of current letter in message
                                    string newBit = ops.convNumberToBits(pixelCol.B);
                                    //append bitstream with new byte
                                    bitString = bitString + newBit;
                                    break;
                                }
                        }
                    }


                }
            }

            //calculate how many pixels are needed 
            int noOfPixels = (int)(bitString.Length / 3) / 4;


            //for each pixel in image.
            for (int i = 0; i < noOfPixels; i++)
            {

                //retrieve pixel at index
                Color pixelCol = bmpCover.GetPixel(pixelIndex.Y, pixelIndex.X);

                int finalR = 0, finalG = 0, finalB = 0;
                //loop through R/G/B of pixel
                for (int rgb = 0; rgb < 3; rgb++)
                {
                    if (!String.IsNullOrEmpty(bitString))
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    //get the binary values of R 
                                    string rBitString = ops.convNumberToBits(pixelCol.R);
                                    //get first 7 digit of R
                                    string rFirstFour = rBitString.Substring(0, 4);
                                    //get first digit from bitStream
                                    string lFirstFour = bitString.Substring(0, 4);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    //merge and convert to back to int
                                    int newR = Convert.ToInt32(rFirstFour + lFirstFour);

                                    finalR = ops.binaryToDecimal(newR);
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    //get the binary values of G
                                    string gBitString = ops.convNumberToBits(pixelCol.G);
                                    //get first 7 digit of G
                                    string gFirstFour = gBitString.Substring(0, 4);
                                    //get first digit from bitStream
                                    string lLastFour = bitString.Substring(0, 4);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    //merge 
                                    int newG = Convert.ToInt32(gFirstFour + lLastFour);

                                    finalG = ops.binaryToDecimal(newG);
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    //get the binary values of B
                                    string bBitString = ops.convNumberToBits(pixelCol.B);
                                    //get first 7 digit of B
                                    string bFirstFour = bBitString.Substring(0, 4);
                                    //get first digit from bitStream
                                    string lLastFour = bitString.Substring(0, 4);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    //merge 
                                    int newB = Convert.ToInt32(bFirstFour + lLastFour);

                                    finalB = ops.binaryToDecimal(newB);
                                    break;
                                }
                        }
                    }
                }
                bmpCover.SetPixel(pixelIndex.Y, pixelIndex.X, Color.FromArgb(finalR, finalG, finalB));

                pixelIndex.Y++;
                if (pixelIndex.Y > bmpCover.Height)
                {
                    pixelIndex.Y = 0;
                    pixelIndex.X++;
                }
            }
            return bmpCover;
        }

        private void SetWH(int width, int height)
        {
            bmpCover.SetPixel(x: bmpCover.Width - 2, y: bmpCover.Height - 1, Color.FromArgb(0,width,height));
        }

        private void SetLength(int inLength_)
        {
            //set length in the final pixel
            //get the binary value of the length
            string lengthBitString = ops.convNumberToBits(inLength_);
            int loopCount = 0;

            Color lengthPixelCol = bmpCover.GetPixel(bmpCover.Width - 1, bmpCover.Height - 1);

            while (lengthBitString.Length < 24)
            {
                lengthBitString = lengthBitString.Insert(0, "0");
            }
            string[] splitInto8s = ops.splitLengthInParts(lengthBitString).Split(' ');


            int lengthR = 0, lengthG = 0, lengthB = 0;

            for (int rgb = 0; rgb < 3; rgb++)
            {
                switch (rgb)
                {
                    //R
                    case 0:
                        {
                            lengthR = ops.binaryToDecimal(Int32.Parse(splitInto8s[1]));
                            break;
                        }
                    //G
                    case 1:
                        {
                            lengthG = ops.binaryToDecimal(Int32.Parse(splitInto8s[2]));
                            break;
                        }
                    case 2:
                        {
                            lengthB = ops.binaryToDecimal(Int32.Parse(splitInto8s[3]));
                            break;
                        }
                }
            }
            bmpCover.SetPixel(bmpCover.Width - 1, bmpCover.Height - 1, Color.FromArgb(lengthR, lengthG, lengthB));

            //end of setting length
        }


    }
}
