using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMPHF004_JQ8Z8Z
{
    internal class PMPHF004_JQ8Z8Z
    {
        static void Main(string[] args)
        {
            char temp;
            char[] text = Console.ReadLine().ToCharArray();
            char[] temp2 = new char[text.Length / 2];
            char[] temp3 = new char[text.Length / 3];
            char[] temp4 = new char[text.Length / 4];

            if (text.Length > 1)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (i != 0 && i % 2 != 0)
                    {
                        temp2[i / 2] = text[i];
                    }
                }
                for (int i = 0; i < text.Length; i++)
                {
                    if (i != 0 && i % 2 != 0)
                    {
                        text[i] = temp2[(temp2.Length - 1) - (i / 2)];
                    }
                }
            }

            if (text.Length > 2)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if ((i + 1) % 3 == 0)
                    {
                        temp3[i / 3] = text[i];
                    }
                }
                temp = temp3[0];
                for (int i = 0; i < temp3.Length - 1; i++)
                {
                    temp3[i] = temp3[i + 1];
                }
                temp3[temp3.Length - 1] = temp;
                for (int i = 0; i < text.Length; i++)
                {
                    if ((i + 1) % 3 == 0)
                    {
                        text[i] = temp3[(i / 3)];
                    }
                }
            }

            if (text.Length > 3)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if ((i + 1) % 4 == 0)
                    {
                        temp4[i / 4] = text[i];
                    }
                }
                temp = temp4[temp4.Length - 1];
                for (int i = temp4.Length - 1; i > 0; i--)
                {
                    temp4[i] = temp4[i - 1];
                }
                temp4[0] = temp;
                for (int i = 0; i < text.Length; i++)
                {
                    if ((i + 1) % 4 == 0)
                    {
                        text[i] = temp4[(i / 4)];
                    }
                }
            }

            string textString = new string(text);
            string[] wordsArray = textString.Split(' ');
            textString = textString.Replace(" ", "");
            int space = 0;
            int index = 0;

            for (int i = 0; i < wordsArray.Length; i++)
            {
                for (int j = 0; j < wordsArray[wordsArray.Length - i - 1].Length; j++)
                {
                    Console.Write(textString[index]);
                    index++;
                }
                if (space < wordsArray.Length - 1)
                {
                    Console.Write(" ");
                    space++;
                }
            }
            Console.ReadLine();
        }
    }
}
