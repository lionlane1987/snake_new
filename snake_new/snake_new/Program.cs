using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_new
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';

            Draw(x1, y1, sym1);

            //Console.SetCursorPosition(x1, y1); удаляем, так как написана нижу функция 'draw'
            //Console.Write(sym1);

            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            Draw(x2, y2, sym2);

            //Console.SetCursorPosition(x2, y2); удаляем, так как написана нижу функция 'draw'
            //Console.Write(sym2);

             
        Console.ReadLine();
        }

        static void Draw(int x, int y, char sym) // объединили две функции в одну
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);

        }
    }
}
