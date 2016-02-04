using System;
using TemplateMethod.Common;

namespace TemplateMethod.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Football();
            game.Play();
            Console.WriteLine();
            game = new Basketball();
            game.Play();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

