using System;

namespace practice_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! this is tre tasks");
            
            Console.WriteLine("#1");
            Console.Write("number = ");
            int number = Int32.Parse(Console.ReadLine()); 
            DrawStaircase(number);
            

            Console.WriteLine("#2");
            Console.Write("vvedite integer number = ");
            number = Int32.Parse(Console.ReadLine());
            bool rez = IsPrime(number);
            if (rez)
            {
                Console.WriteLine("это простое число");
            }
            else
            {
                Console.WriteLine("это не простое число");
            }

            Console.WriteLine("#3");
            Console.Write("введите строку = ");
            string palindr = Console.ReadLine();

            bool rez_palindr = IsPalindrome(palindr);
            if (rez_palindr)
            {
                Console.WriteLine("yes, это Палиндром");
            }
            else
            {
                Console.WriteLine("no, это не палиндром");
            }
        }
        
        ///<summary>     
        ///Задача 1 - Лесенка
        ///В метод передается целое число n (типа int).
        ///Нужно вывести в консоль "лесенку": 
        ///Количество строк = количеству символов в последней строке = числу n.
        ///Ширина 1 пробела примерно равна ширине символа.
        ///</summary>        
        static void DrawStaircase(int number)
        {
            string[] drawStars = new string[number];
            string[] strokaChar = new string[number];
            for (int i = 0; i < number; i++)
            {
                strokaChar[i] = " ";
            }            
            for (int i = 0; i<number; i++)
            {
                strokaChar[number - i - 1] = "#";           
                drawStars[i] = String.Join("",strokaChar);                
            }
            for (int i = 0; i < drawStars.Length; i++)
            {
                Console.WriteLine(drawStars[i]);
            }
            return;
        }

        /// <summary>
        /// Задача 2 - Простые числа
        /// Определить, является ли число простым. 
        /// </summary>
        static bool IsPrime(int x)
        {
            int  d = 2;
            if (x == 1)
                return true;
            else
                while (x % d != 0)
                {
                    d++;
                }
            return (d == x);
        }

        /// <summary>
        /// Задача 3 - Палиндром 
        /// Определить, является ли строка палиндромом. Например, "а роза упала на лапу Азора".
        /// Пробелы предлагаю не учитывать, и большие буквы тоже сделать строку состоящей из маленьких букв:str.ToLower()
        /// Заменить символы в строке (в данном случае - пробел на пустую строку)Console.WriteLine(str.Replace(" ", ""));
        /// </summary>         
        static bool IsPalindrome(string palindr)
        {
            string new_str = palindr.ToLower().Replace(" ", "");            
            int dl = new_str.Length;
            bool p = true;
            for (int i = 0; i < dl / 2; i++)
            {
                if (new_str[i] != new_str[dl-i-1])
                {
                    p = false;      
                    break;  
                }            
            }           
        return (p); 
        }
    }
}
