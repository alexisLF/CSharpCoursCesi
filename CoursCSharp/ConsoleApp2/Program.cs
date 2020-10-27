using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COUCOUUUU");
            WorkEvent();
            System.Threading.Thread.Sleep(5000);
        }

        static void WorkInterface()
        {
            Voiture v = new Voiture();
            v.Avancer();
        }

        static void WorkDelegate()
        {
            Velo v = new Velo();
            v.Show();
        }

        static void WorkDelegateMulticast()
        {
            TabsSorting s = new TabsSorting();
            int[] tab = { 1, 2, 53, 5 };
            s.Demo(tab);
        }

        static void WorkStringFormatter()
        {
            Console.WriteLine("Work without delegate");
            string s = "BonJOur";
            Console.WriteLine(s);
            Console.WriteLine(StringFormat.UpperCase(s));
            Console.WriteLine(StringFormat.LowerCase(s));
        }

        static void WorkStringFormatterDelegate()
        {
            Console.WriteLine("Work with delegate");

            StringFormatDelegate stringFormatDelegate = new StringFormatDelegate();
            stringFormatDelegate.Show();
        }

        static void WorkGeneric<T>()
        {
            Console.WriteLine("cette fonction est du type : " + typeof(T).Name);
        }

        public static T Add<T>(T in1, T in2)
        {
            var d1 = Convert.ToDouble(in1);
            var d2 = Convert.ToDouble(in2);
            return (T)(dynamic)(d1 + d2);
        }

        public static void WorkException()
        {
            try
            {
                int result = 15 / int.Parse("0");
                Console.WriteLine(result);
                int p = 0;
            }
            catch (DivideByZeroException e)
            {
                Console.Write(e.Message);
                Console.ReadLine();
            }
        }

        public static void WorkEvent()
        {
            Article a = new Article();
            a.Price = 200;
            Article.DelegateChange del = NewPrice;
            a.PriceChange += del;
            a.Discount();
            Console.WriteLine(a.Price);
        }

        public static void NewPrice(decimal price)
        {
            throw new Exception();
        }
    }

    interface ISeDeplacer
    {
        void Avancer();
    }

    class Voiture: ISeDeplacer
    {
        public void Avancer()
        {
            Console.WriteLine("J'avance");
        }
    }

    class Velo{
        public delegate string seDeplacer(int x, int y);

        public string Avancer(int x, int y)
        {
            string s = "J'avance de " + x + " et de " + y ;
            return s;
        }

        public string Reculer(int x, int y)
        {
            string s = "Je recule de " + x + " et de " + y; ;
            return s;
        }

        public void Show()
        {
            seDeplacer sd  = Avancer;
            string avancer = sd(20, 30);
            Console.WriteLine(avancer);
            sd = Reculer;
            string reculer = sd(20, 30);
            Console.WriteLine(reculer);
        }

    }

    class TabsSorting
    {
        private delegate void DelegateSort(int[] tab);

        private void AscSort(int[] tab)
        {
            Array.Sort(tab);
            foreach(int i in tab)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        private void DescSort(int[] tab)
        {
            Array.Sort(tab);
            Array.Reverse(tab);
            foreach (int i in tab)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        public void Demo(int[] tab)
        {
            DelegateSort sort = AscSort;
            sort += DescSort;
            sort(tab);
        }
    }

    static class StringFormat
    {
        public static string UpperCase(string s)
        {
            return s.ToUpper();
        }

        public static string LowerCase(string s)
        {
            return s.ToLower();
        }
    }

    class StringFormatDelegate
    {
        private delegate void DelegateString(string s);

        public static void UpperCase(string s)
        {
            Console.WriteLine( s.ToUpper());
        }

        public static void LowerCase(string s)
        {
            Console.WriteLine( s.ToLower());
        }

        public void Show()
        {
            DelegateString delegateString = UpperCase;
            delegateString += LowerCase;
            delegateString("BonJOuR");
            Console.WriteLine();
        }
    }

    class Article
    {
        public delegate void DelegateChange (decimal newPrice);
        public event DelegateChange PriceChange;
        public decimal Price { get; set; }
        public void Discount()
        {
            Price /= 2;
            PriceChange?.Invoke(Price);
        }

        
    }
}
