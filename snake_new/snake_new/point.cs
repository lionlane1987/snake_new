using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_new
{
    class point // создаем класс point
    {
        public int x; // говорим что класс состоит из данных (указываем переменные)
        public int y;
        public char sym;

        public void Draw() // говорим что класс состоит из функции
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);

        }

    }
}
