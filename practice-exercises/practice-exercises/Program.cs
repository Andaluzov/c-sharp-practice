using System;

namespace practice_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SayHello();
            Task1();
            Task2();
            Task3();
        }
        static void SayHello()
        {
            Console.WriteLine("Hello");

        }
        static void Task1()
        {
            Console.WriteLine("Task1");
            /*
             Задача 1 - Лесенка
                В метод передается целое число n (типа int).
                Нужно вывести в консоль "лесенку": 
                Количество строк = количеству символов в последней строке = числу n.
                Ширина 1 пробела примерно равна ширине символа.
              */
            //char[] stars;
            int index;
            Console.Write("n = ");
            int number = Int32.Parse(Console.ReadLine());
            char[] stars = new char[number];
            for (int i = 0; i < number; i++)
            {
                stars[i] = ' ';
            }

            for (int i = 0; i < number; i++)
            {               
                index = number - i-1;
                stars[index] = '#';
                MasPrint(stars);
                Console.WriteLine();
            }
        } 
        //write massiv
        static void MasPrint(char[] massiv)
        {
            for (int i = 0; i < massiv.Length; i++)
            { 
                Console.Write(massiv[i]);
            }                    
        }
        static void Task2()
        {
            Console.WriteLine("Task2");
            /*
             Задача 2 - Простые числа
            Определить, является ли число простым. 
            Простое число: целое положительное число больше 1, 
            делится без остатка только на себя и 1.
              */
            int d;
            Console.Write("vvedite integer n = ");
            int number = Int32.Parse(Console.ReadLine());
            d = 2;
            while (number % d != 0)
            {
                d ++;
                               
            }
            if (d == number)
            {
                Console.WriteLine("True, это простое число");
            }
            else
            {
                Console.WriteLine("False, это не простое число");
            }

        }
        static void Task3()
        {
            Console.WriteLine("Task3");
            /*
            Задача 3 - Палиндром 
            Определить, является ли строка палиндромом. Например, "а роза упала на лапу Азора".
            Пробелы предлагаю не учитывать, и большие буквы тоже
            сделать строку состоящей из маленьких букв:
            str.ToLower()
            Заменить символы в строке (в данном случае - пробел на пустую строку)
            Console.WriteLine(str.Replace(" ", ""));
              */
            
            Console.Write("введите строку = ");
            string new_str = Console.ReadLine().ToLower().Replace(" ", "");
                       
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
            if (p)
            {
                Console.WriteLine("yes, это Палиндром");
            }
            else
            {
            Console.WriteLine("no, это не палиндром");
            }
        
        }
    }
}
