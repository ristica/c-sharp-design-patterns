using System;
using Decorator.Common.Component;
using Decorator.Common.ConcreteComponent;
using Decorator.Common.ConcreteDecoator;

namespace Decorator.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("creating new ice cream...");
            Console.WriteLine();

            IceCream ice = new MyIce();

            Console.WriteLine("Plain ice => $ {0}", ice.GetCost()); 

            Console.WriteLine();

            ice = new IceWithSprinkles(ice);
            Console.Write("{0}", ice.GetIngredients());
            Console.Write(" => $ {0}", ice.GetCost()); 

            Console.WriteLine();
            Console.WriteLine();

            ice = new IceWithMandM(ice);
            Console.Write("{0}", ice.GetIngredients());
            Console.Write(" => $ {0}", ice.GetCost()); 

            Console.WriteLine();
            Console.WriteLine();

            ice = new IceWithChocolateSauce(ice);
            Console.Write("{0}", ice.GetIngredients());
            Console.Write(" => $ {0}", ice.GetCost()); 

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
