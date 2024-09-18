using System;

namespace video007 {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = DateTime.Now;

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d1.Day);

            Console.ReadLine();
        }
    }
}
