using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';

            DrawSymbol(x1, y1, sym1);

            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            DrawSymbol(x2, y2, sym2);




            Console.ReadLine();


        }

        static void DrawSymbol(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
