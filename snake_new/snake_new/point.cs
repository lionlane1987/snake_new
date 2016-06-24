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

        public point()
        {

        }

        //СОЗДАЕМ КОНСТРУКТОР
        public point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        //Тест
        //public point()
        //{
        //    Console.WriteLine("Создается новая точка");

        //}


        public void Draw() // говорим что класс состоит из функции
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);

        }

    }
}
