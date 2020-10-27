using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test String Formatter");
            WorkStringFormatter();
            Console.WriteLine();
            WorkStringFormatterDelegate();
            System.Threading.Thread.Sleep(5000);
        }

        static void WorkStringFormatter()
        {
            Console.WriteLine("Work without delegate");
            string s = "BonJOur";
            Console.WriteLine("string to test : " + s);
            Console.WriteLine(StringFormat.UpperCase(s));
            Console.WriteLine(StringFormat.LowerCase(s));
        }

        static void WorkStringFormatterDelegate()
        {
            Console.WriteLine("Work with delegate");
            StringFormatDelegate stringFormatDelegate = new StringFormatDelegate();
            stringFormatDelegate.Show();
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
            Console.WriteLine(s.ToUpper());
        }

        public static void LowerCase(string s)
        {
            Console.WriteLine(s.ToLower());
        }

        public void Show()
        {
            DelegateString delegateString = UpperCase;
            delegateString += LowerCase;
            delegateString("BonJOuR");
            Console.WriteLine();
        }
    }
}
