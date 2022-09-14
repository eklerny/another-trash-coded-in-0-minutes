using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string lang = "de";

            switch (lang)
            {
                case "ru":
                    Console.WriteLine("Привет Мир!");
                    break;
                case "en":
                    Console.WriteLine("Hello World!");
                    break;
                case "de":
                    Console.WriteLine("Hallo, Welt!");
                    break;
                case "jp":
                    Console.WriteLine("こんにちは、世界!");
                    break;
                case "kz":
                    Console.WriteLine("Сәлем Әлем!");
                    break;

                default:
                    Console.WriteLine("Локализация не найдена!");
                    break;
            }
        }
    }
}
