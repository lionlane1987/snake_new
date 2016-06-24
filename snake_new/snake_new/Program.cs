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
            point p1 = new point(1, 3, '*'); // классу point присваим имя p1
           
            //Сокращаем работу прописывает в классе point сразу все данные 
            /* p1.x = 1;
            p1.y = 3;
            p1.sym = '*';*/

            //убирае так как добавили в класс функцию
            //Draw (p1.x, p1.y, p1.sym); 

            p1.Draw();

            //ВМЕСО ЭТОГО ИСПОЛЬЗУЕМ КЛАСС POINT

            //int x1 = 1; 
            //int y1 = 3;
            //char sym1 = '*';

            //Draw(x1, y1, sym1);

            //УБИРАЕМ, ТАК КАК НАПИСАНА ФУНКЦИЯ DRAW

            //Console.SetCursorPosition(x1, y1); 
            //Console.Write(sym1);

            point p2 = new point(4,5,'#');
                   
            

            p2.Draw();


            //int x2 = 4;
            //int y2 = 5;
            //char sym2 = '#';

            //Draw(x2, y2, sym2);

            //Console.SetCursorPosition(x2, y2); установка курсора с координатами (4,5)    // удаляем, так как написана нижу функция 'draw' 
            //Console.Write(sym2); выводим на экран

             
        Console.ReadLine(); //показывать пока не нажмем Enter
        }


        //УБРАЛИ ТАК СОЗДАЛИ ДАННУЮ ФУНКЦИЮ В КЛАССЕ
        //static void Draw(int x, int y, char sym) // объединили две функции в одну (отвечает за отображение функции на консоли)
        //{
        //    Console.SetCursorPosition(x, y);
        //    Console.Write(sym);

        //}
    }
}
