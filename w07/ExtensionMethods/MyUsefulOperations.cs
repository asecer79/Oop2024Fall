using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w07.ExtensionMethods
{
    public static class MyUsefulOperations
    {
        public static int CountEnglishCharacter(this string text)
        {

            text=text.Replace(" ","");

            int count = 0;
            foreach (var character in text)
            {
                int code = (int)character;
                //a-z = 97-122
                //A-Z = 65-90
                if ((97<=(int)character && (int)character <= 122)|| (65 <= (int)character && (int)character <= 90))
                {
                    count++;
                }
            }

            return count;
        }

        public static int CountNonEnglishCharacter(this string text)
        {
            text = text.Replace(" ", "");

            int count = text.Length;

            count = count - CountEnglishCharacter(text);

            return count;
        }

    }
}
