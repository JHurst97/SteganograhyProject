using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionProject
{
    class Operations
    {
        public int binaryToDecimal(int n)
        {
            int num = n;
            int dec_value = 0;

            // Initializing base1 
            // value to 1, i.e 2^0 
            int base1 = 1;

            int temp = num;
            while (temp > 0)
            {
                int last_digit = temp % 10;
                temp = temp / 10;

                dec_value += last_digit * base1;

                base1 = base1 * 2;
            }

            return dec_value;
        }

        public long binaryToDecimalLong(long n)
        {
            long num = n;
            long dec_value = 0;

            // Initializing base1 
            // value to 1, i.e 2^0 
            long base1 = 1;

            long temp = num;
            while (temp > 0)
            {
                long last_digit = temp % 10;
                temp = temp / 10;

                dec_value += last_digit * base1;

                base1 = base1 * 2;
            }

            return dec_value;
        }

        public string splitLengthInParts(string in_)
        {
            string input = in_;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 8 == 0)
                    sb.Append(' ');
                sb.Append(input[i]);
            }
            string formatted = sb.ToString();
            return formatted;
        }

        public string getFromStart(string in_, int count)
        {

            char[] charArr = in_.ToCharArray();
            string out_ = "";
            int fromEnd = in_.Length - count;
            for (int i = 0; i < in_.Length - fromEnd; i++)
            {
                out_ += charArr[i];
            }

            return out_;
        }
        public string removeFromStart(string in_, int count)
        {

            char[] charArr = in_.ToCharArray();
            string out_ = "";
            int fromStart = in_.Length - count;
            for (int i = fromStart; i < in_.Length; i++)
            {
                out_ += charArr[i];
            }

            return out_;
        }


        //WORKING!
        public string convLetterToBits(string in_)
        {
            char letter = Convert.ToChar(in_);
            //convert letter to 32-bit int
            int value = Convert.ToInt32(letter);
            //converting 32-bit int to (string) bits
            BitArray ba = new BitArray(new int[] { value });
            string bits32 = "";
            for (int c = 0; c < ba.Length; c++)
            {
                if (c % 8 < 7) //get first 8 bits of the 32bit int
                {
                    //true = 1, false = 0
                    if (ba[c])
                    {
                        bits32 += 1;
                    }
                    else
                    {
                        bits32 += 0;
                    }
                }
            }
            //get only the first byte of the 32bit (4 bytes) int and reverse using the function below 
            string bitString = Reverse(bits32.Substring(0, 8));       //we now have the letter in binary. 
            //Console.WriteLine("bits: " + bitString + "||| value: " + value + "||| letter: " + letter);
            return bitString;
        }

        public string convNumberToBits(int in_)
        {
            string binary = Convert.ToString(in_, 2);

            while (binary.Length < 8)
            {
                binary = "0" + binary;
            }

            return binary;
        }

        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string BinaryToString(string data)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                if (data.Length > 8) { 
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            } }

            return Encoding.ASCII.GetString(byteList.ToArray());
        }
    }
}
