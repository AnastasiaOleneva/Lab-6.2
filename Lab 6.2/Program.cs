using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string text = Console.ReadLine();
            string textLower = string.Empty;
            string textReverse = string.Empty;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (text[i].ToString() != " ")
                {

                    textReverse += text[i].ToString().ToLower();
                }


            }

            for (int j = 0; j < text.Length; j++)
            {
                if (text[j].ToString() != " ")
                {
                    textLower += text[j].ToString().ToLower();
                }
            }
            if (textLower == textReverse)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }

            Console.ReadKey();


        }
    }
}
