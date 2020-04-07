using System;


namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //string names = args[0];
            //Console.WriteLine(" Siema, " + names); 
            foreach (var item in args)
            {
                Console.WriteLine("Siema, " + item);
            }
        }
    }
}
