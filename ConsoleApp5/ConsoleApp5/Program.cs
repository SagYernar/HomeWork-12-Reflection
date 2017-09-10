using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №1\n");

            Type typeForMethods = typeof(Console);

            foreach (MethodInfo method in typeForMethods.GetMethods())
            {
                Console.WriteLine(method.ToString());
            }

            //Способ через GetType
            //Type type1 = Type.GetType("System.Console");

            //foreach (MethodInfo method in type1.GetMethods())
            //{
            //    Console.WriteLine(method.ToString());
            //}

            Console.WriteLine("\nНажмите Enter для демонстрации следующей задачи");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Задача №2\n");

            Properties properties = new Properties();
            Type typeForProperties = typeof(Properties);

            foreach (PropertyInfo property in typeForProperties.GetProperties())
            {
                Console.WriteLine(property.ToString() + " - " + property.GetValue(properties));
            }
            Console.ReadLine();




        }
    }
}
