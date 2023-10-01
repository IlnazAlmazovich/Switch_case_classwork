using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string type;//определяем тип числа
            switch(a)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    type = "Число является нечётным";
                    break;

                case 2:
                case 4:
                case 6:
                case 8:
                case 10:
                    type = "Число является чётным";
                break;

                default:
                    type = "Вы ввели число 0 или число больше 10!";
                    break;
            }
            Console.WriteLine(type);
        }
    }
}
