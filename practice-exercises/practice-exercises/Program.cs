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
    }
}
