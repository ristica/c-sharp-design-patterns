using System;

namespace TemplateMethod.Common
{
    public class Basketball : Game
    {
        protected override void InitializeGame()
        {
            Console.WriteLine("Enjoy BASKETBALL game :)");
        }

        protected override void StartGame()
        {
            Console.WriteLine("Basketball game started!");
        }

        protected override void EndGame()
        {
            Console.WriteLine("Basketball match is over...");
        }
    }
}
