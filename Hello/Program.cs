using System;


namespace Hello
{
    class Program
    {
        static void Main(string[] args) 
        {
            valueTypes();

            for (; ; )
            {
                Greeting();
                CheckAge();
                Settings();
            }



        }

        private static void valueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
                
        }

        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        private static void CheckAge()
        {
            Console.Write("What is your age?");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Great lets drink beer");
            }

            else if (result == false)
            {
                Console.WriteLine("Give only numbers!");
            }

            else
            {
                Console.WriteLine("Ooops maybe milk?");
            }
        }

        private static void Greeting()
        {
            Console.WriteLine("Give me your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
        }
    }
}
