using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Praktan_6
{
    internal class Class1
    {
        public static ConsoleKeyInfo key;
        public static void Put()
        {
            Console.WriteLine("Введите путь до файла (с названием), который вы хотите октрыть");
            Console.WriteLine("--------------------------------------------------------------");
            string text = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Сохраните файл в одном из трёх форматов: json, txt, xml - F1. Чтобы закрыть программу нажмите ESC");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine(File.ReadAllText(text));
            /*Console.WriteLine("Введите путь файла(с названием), куда вы хотите сохранить текст?");
            Console.WriteLine("--------------------------------------------------------------");*/
            do
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {

                    break;
                }
                else if (key.Key == ConsoleKey.F1)
                {
                    Console.Clear();
                    Console.WriteLine("Введите путь файла(с названием), куда вы хотите сохранить текст?");
                    Console.WriteLine("--------------------------------------------------------------");
                    CreatFile();

                }
            } while (key.Key != ConsoleKey.Escape);

        }
        public static void ConvertToJason()
        {
            List<Figure> figureList = new List<Figure>();
            Figure figure = new Figure();
           figure.form = "Прямоуголник";
           figure.length = 17;
           figure.Height = 18;
           figure.form2 = "Квадрат";
           figure.length2 = 20;
           figure.Height2 = 29;
           figure.form3 = "Треугольник";
           figure.length3 = 27;
           figure.Height3 = 30;
        }

        public static void CreatFile()
        {
            List<Figure> figureList = new List<Figure>();

            /*List<data> _data = new List<data>();
            _data.Add(new data()
            {
                Id = 1,
                SSN = 2,
                Message = "A Message"
            });

            string text2 = Console.ReadLine();
            Console.Clear();
            string json = JsonSerializer.Serialize(ConvertToJason);
            File.WriteAllText(text2, json);*/
        }













        

        

    }
}
