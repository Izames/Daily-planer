using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainMenu;

namespace Daily_planer
{
    internal class fir
    {
        public void one(int number)
        {
            Console.Clear();
            List<string[]> list = new List<string[]>()
            {
                new string[]{"14.10.22 \n--------\n\t1 часть дня \n\t2 часть дня \n\t3 часть дня \n\t вернуться",
                    "14.10.22 первая половина дня \n------------------\nв первой половине дня надо убраться в квартире и начать разгребать домашние дела, оставленные на выходные",
                    "14.10.22 вторая половина дня \n------------------\nво второй половине дня нужно сделать первую из четырех практических",
                    "14.10.22 третья половина дня \n------------------\nв третьей половине дня можно зайти в дискорд и просто отдохнуть"},
                new string[]{"15.10.22 \n--------\n\t1 часть дня \n\t2 часть дня \n\t3 часть дня \n\t вернуться",
                    "14.10.22 первая половина дня \n------------------\nв первой половине дня надо зайти в пекарню и взять себе перекус на утро",
                    "14.10.22 вторая половина дня \n------------------\nво второй половине дня надо вновь сосредоточиться на практической",
                    "14.10.22 третья половина дня \n------------------\nв третьей половине дня нужно попрактиковаться в aseprite" },
                new string[]{"16.10.22 \n--------\n\t1 часть дня \n\t2 часть дня \n\t3 часть дня \n\t вернуться",
                    "14.10.22 первая половина дня \n------------------\nв первой половине дня надо сходить в аптеку",
                    "14.10.22 вторая половина дня \n------------------\nво второй половине дня надо начать готовить на неделю",
                    "14.10.22 третья половина дня \n------------------\nв третьей половине дня можно во что-то поиграть" },
                new string[]{"17.10.22 \n--------\n\t1 часть дня \n\t2 часть дня \n\t3 часть дня \n\t вернуться",
                    "14.10.22 первая половина дня \n------------------\nв первой половине дня сдать егэ по борьба",
                    "14.10.22 вторая половина дня \n------------------\nво второй половине дня надо сходить на тренировку",
                    "14.10.22 третья половина дня \n------------------\nв третьей половине дня вспомнить о собаке" },
                new string[]{"17.10.22 \n--------\n\t1 часть дня \n\t2 часть дня \n\t3 часть дня \n\t вернуться",
                    "14.10.22 первая половина дня \n------------------\nв первой половине дня погулять с собакой",
                    "14.10.22 вторая половина дня \n------------------\nво второй половине дня слепить снеговика",
                    "14.10.22 третья половина дня \n------------------\nв третьей половине дня лечь пораньше" },
            };
            if (number == 0)
                txt(list[0]);
            if (number == 1)
                txt(list[1]);
            if (number == 2)
                txt(list[2]);
            if (number == 3)
                txt(list[3]);
            if (number == 4)
                txt(list[4]);

        }
        static void txt(string[] zametka)
        {
             Console.WriteLine(zametka[0]);
             int cursor = 2;
             Console.SetCursorPosition(2, 2);
             Console.WriteLine("-->");
             ConsoleKeyInfo Clavisha = Console.ReadKey();
             while (Clavisha.Key != ConsoleKey.Enter)
             {
                 Console.Clear();
                 Console.WriteLine(zametka[0]);
                 if (Clavisha.Key == ConsoleKey.UpArrow)
                 {
                     cursor--;
                 }
                 if (Clavisha.Key == ConsoleKey.DownArrow)
                 {
                     cursor++;
                 }
                 Console.SetCursorPosition(0, cursor);
                 Console.WriteLine("-->");
                 Clavisha = Console.ReadKey();
             }
             if (cursor == 2)
             {
                 Console.Clear();
                 Console.WriteLine(zametka[1]);
             }
             if (cursor == 3)
             {
                 Console.Clear();
                 Console.WriteLine(zametka[2]);
             }
             if (cursor == 4)
             {
                 Console.Clear();
                 Console.WriteLine(zametka[3]);
             }
             if (cursor == 5)
            {
                first_Page go = new first_Page();
                go.zametki();
            }
             Console.ReadKey();
             fir adres = new fir();
             int tyfytfuyf = 0;
             adres.one(tyfytfuyf);
        }
    }
}
