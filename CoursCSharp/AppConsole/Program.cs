using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COUCOUUUU");
            workReference();
            System.Threading.Thread.Sleep(5000);

        }

        static void Square (int a, int b)
        {
            a *= a;
            b *= b;
            Console.WriteLine("a² = " + a +  " b²= " + b);

        }

        static void workSquare()
        {
            uint unsignedVar = 3;
            Square(3, 6);
        }

        enum Module
        {
            Start,
            Gold,
            Expert
        }

        static void workEnum()
        {
            Module m = Module.Gold;
            Console.WriteLine(m);
            Console.WriteLine((int) m);
        }

        struct Coordinates
        {
            public int x { get; set; }
            public int y { get; set; }

            public Coordinates(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public static void Show()
            {
                Coordinates plot1 = new Coordinates(9, 8);
                Coordinates plot2 = new Coordinates
                {
                    x = 2,
                    y = 3
                };
                Console.WriteLine("plot 1 : x =" + plot1.x + ", y = " + plot1.y);
                Console.WriteLine("plot 2 : x =" + plot2.x + ", y = " + plot2.y);
            }
        }

        public class People
        {
            public int age { get; set; }

            public People(int agePeople)
            {
                setAge(agePeople);
            }

            private void setAge(int agePeople)
            {
                this.age = agePeople;
            }
        }

        static void workStruct()
        {
            Coordinates.Show();
        }

        public static class Tuple
        {
            static (int x, double y) Treatment(int a, double b)
            {
                a += 10;
                b += 15.5;
                return (a, b);
            }

            public static void show()
            {
                Console.WriteLine("TUPLE " + Treatment(10, 15.5));
            }
        }

        static void workTuple()
        {
            Tuple.show();
        }

        static void SquareObject(People a, People b)
        {
            a.age *= a.age;
            //b.age *= b.age;
            Console.WriteLine(a.age + " " + b.age);
        }
        static void workReference()
        {
            People p1 = new People(15);
            People p2 = p1;
            Console.WriteLine(p1.age + " " + p2.age);
            SquareObject(p1, p2);



        }
    }
}
