using System;

namespace Shapes
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int circleinput = int.Parse(Console.ReadLine());
            int Width = int.Parse(Console.ReadLine());
            int Length = int.Parse(Console.ReadLine());
            IDrawable rectangle = new Rectangle(Width, Length);
            IDrawable circle = new Circle(circleinput);
            circle.Draw();
            rectangle.Draw();
        }
    }
}
