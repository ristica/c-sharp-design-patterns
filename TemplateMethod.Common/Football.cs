using System;

namespace TemplateMethod.Common
{
    public class Football : Game
    {
        protected override void InitializeGame()
        {
            Console.WriteLine("Enjoy FOOTBALL game :)");
        }

        protected override void StartGame()
        {
            Console.WriteLine("Football game started!");
        }

        protected override void EndGame()
        {
            Console.WriteLine("Football match is over...");
        }
    }
}
