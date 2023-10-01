using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //По введённому пользователем числу определить название этого числа. (Взять числа от 1 до 5).

            Console.WriteLine("Введите число: ");
            int number = int.Parse(Console.ReadLine()); // переменная для запоминания числа
            string name; //переменная для записи названия числа
            
            switch(number)
            {
                case 1:  //если ввели число 1
                    name = "Единица";
                break;

                case 2:  //если ввели число 2
                    name = "Двойка";
                    break;
                case 3:  //если ввели число 3
                    name = "Тройка";
                    break;
                case 4: //если ввели число 4
                    name = "Четвёрка";
                    break;
                case 5:  //если ввели число 5
                    name = "Пятёрка";
                    break;
                default: //ввели данные больше чем в заданном диапазоне
                    name = "Таких чисел мы не знаем";
                    break;
            }
            Console.WriteLine(name); //вывод данных в консоль

        }
    }
}
