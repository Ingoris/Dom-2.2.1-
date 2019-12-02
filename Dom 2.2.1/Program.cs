using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dom_2._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ФИО: ");
            string name = Console.ReadLine();
            Console.Write("Введите Возраст: ");
            int age = int.Parse (Console.ReadLine());
            Console.Write("Введите Адрес: ");
            string address = Console.ReadLine();
            Console.Write("Введите Телефон: ");
            string phone = Console.ReadLine();
            //var phone = Console.ReadLine();
            Console.Write("Введите Рост: ");
            //var height = Console.ReadLine();
            string height = Console.ReadLine();
            Console.Write("ФИО: {0} \nВозраст: {1} \nАдрес: {2} \nТелефон: {3} \nРост: {4} \n", name, age, address, phone, height);

            
            Console.ReadKey();

        }
    }
}
