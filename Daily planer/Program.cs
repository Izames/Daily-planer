using Daily_planer;

namespace MainMenu
{
    internal class first_Page
    {
        static void Main()
        {
            first_Page go = new first_Page();
            go.zametki();
        }
        public void zametki()
        {
            Console.Clear();
            List<string> list = new List<string>()
            {
                {"14.10.22" },
                {" | 15.10.22" },
                {" | 16.10.22" },
                {" | 17.10.22" },
                {" | 18.10.22" },
            };
            Console.WriteLine("Добро пожаловать в ежедневник. Выберите то, что хотите сделать");
            Console.Write(list[0]);
            Console.Write(list[1]);
            Console.Write(list[2]);
            Console.Write(list[3]);
            Console.WriteLine(list[4]);
            Console.WriteLine("^");
            int cursor = 0;
            ConsoleKeyInfo Clavisha = Console.ReadKey();
            while (Clavisha.Key != ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("Добро пожаловать в ежедневник. Выберите то, что хотите сделать");
                Console.Write(list[0]);/*0-8*/
                Console.Write(list[1]);/*10-20*/
                Console.Write(list[2]);/*21-infinity*/
                Console.Write(list[3]);/*21-infinity*/
                Console.Write(list[4]);/*21-infinity*/
                if (Clavisha.Key == ConsoleKey.RightArrow)
                    cursor += 11;
                if (Clavisha.Key == ConsoleKey.LeftArrow)
                    cursor -= 11;
                Console.SetCursorPosition(cursor, 2);
                Console.WriteLine("^");
                Clavisha = Console.ReadKey();
            }
            Console.WriteLine(cursor);
            if (cursor == 0)
            {
                fir Firs = new fir();
                Firs.one(0);
            }
            if (cursor == 11)
            {
                fir Firs = new fir();
                Firs.one(1);
            }
            if (cursor == 22)
            {
                fir Firs = new fir();
                Firs.one(2);
            }
            if (cursor == 33)
            {
                fir Firs = new fir();
                Firs.one(3);
            }
            if (cursor == 44)
            {
                fir Firs = new fir();
                Firs.one(4);
            }        
        }
    }
}