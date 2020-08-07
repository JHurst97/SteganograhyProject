using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionProject
{
    class Caesar
    {

        char[] alpha = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!£$%^&*()_+-=<>,./?@';:#~[{]}`¬|".ToCharArray();

        public string encrypt(string input_)
        {
            char[] inArr = input_.ToCharArray();
            string encrypted = "";
            //for each letter in inut string
            for (int i = 0; i < inArr.Length; i++)
            {
                //compare against alhabet
                for (int j = 0; j < alpha.Length; j++)
                {
                    string c1 = inArr[i].ToString();
                    string c2 = alpha[j].ToString();
                    int c = string.Compare(c1, c2);
                    if (c == 0)
                    {
                        //check if out of bounds
                        if (j + 2 >= alpha.Length)
                        {
                            int overlap = (j + 2) - alpha.Length;
                            encrypted += alpha[overlap].ToString();
                        }
                        else
                        {
                            encrypted += alpha[j + 2].ToString();
                        }
                    }
                }
            }
            return encrypted;

        }

        public string decrypt(string input_)
        {
            char[] inArr = input_.ToCharArray();
            string decrypted = "";
            //for each letter in inut string
            for (int i = 0; i < inArr.Length; i++)
            {
                //compare each letter against alhabet
                for (int j = 0; j < alpha.Length; j++)
                {
                    string c1 = inArr[i].ToString();
                    string c2 = alpha[j].ToString();
                    int c = string.Compare(c1, c2);
                    int asc = (int)alpha[j];
                    if (c == 0)
                    {
                        //check if out of bounds
                        if (j - 2 < 0)
                        {
                            int overlap = (j - 2) + alpha.Length;
                            decrypted += alpha[overlap].ToString();
                        }
                        else
                        {
                            decrypted += alpha[j - 2].ToString();
                        }
                    }
                }
            }
            return decrypted;
        }

    }
}
