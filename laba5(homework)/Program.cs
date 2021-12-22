using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba5_homework_
{
    class Program
    {
        static bool RememberPassword(string[] decodepass,ref string binarycode)
        {
            for (int i = 0; i < decodepass.Length;i++ )
            {
                string t ="";
                for (int j = 0; j < decodepass[i].Length; j++)
                {
                    t = t + Convert.ToString(decodepass[i][j],2);
                }
                if (t.Equals(binarycode))
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            //#1
            Console.WriteLine("Task1");
            string[] probablyPass = { "password", "pass123", "pass" };
            StreamReader reader = new StreamReader("pass.txt");
            string passBinary = reader.ReadToEnd();
            passBinary = passBinary.Replace(" ", "");
            if (RememberPassword(probablyPass, ref passBinary))
            {
                Console.WriteLine(passBinary);
            }
            else
            {
                Console.WriteLine("false");
            }
            //#2
            Console.WriteLine("Task2");
            Console.WriteLine("Введите 4 слова, которые кричит Гордон");
            string words = Console.ReadLine();
            string vowels = "еёиоуэюяЕЁИОУЭЮЯ";
            if(words.Split().Length == 4)
            {
                string translated = words.Replace(" ", " !!! ").Replace("а", "@").Replace("А", "@").ToUpper();
                for(int i = 0;i < translated.Length; i++)
                {
                    if (vowels.Contains(translated[i]))
                    {
                        translated = translated.Replace(translated[i], '*'); 
                    }
                }
                Console.WriteLine($"Гордон сказал {translated}");
            }
            else
            {
                Console.WriteLine("Гордон молчит...");
            }
        }
    }
}
