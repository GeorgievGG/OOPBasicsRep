using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.DrawingTool
{
    public class CorDraw
    {
        public static void Main()
        {
            var type = Console.ReadLine();
            if (type == "Square")
            {
                var size = int.Parse(Console.ReadLine());
                var squareFigure = new Square(size);
                PrintFigure(squareFigure);
            }
            else if (type == "Rectangle")
            {
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());
                var rectFigure = new Rectangle(a, b);
                PrintFigure(rectFigure);
            }
        }
        public static void PrintFigure(Rectangle figure)
        {
            for (int i = 0; i < figure.B; i++)
            {
                Console.Write('|');
                for (int j = 0; j < figure.A; j++)
                {
                    if (i == 0 || i == figure.B - 1)
                    {
                        Console.Write('-');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine('|');
            }
        }

    }
}
