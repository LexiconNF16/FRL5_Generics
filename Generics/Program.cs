using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Util.Max(4, 5));
            //Console.WriteLine(Util.Max(4.1, 5.2));
            //Console.WriteLine(Util.Max(4, 5.2));
            //Console.WriteLine(Util.Max(4.2, 5));
            //Console.WriteLine(Util.Max("2", "10"));
            //Console.WriteLine(Util.Max(true, false));

    var isoPair = new Pair<float>(4.3f, 1.9f);
    var pair = new Pair<int, string>(5, "hej");
    var first = pair.First;
    var second = pair.Second;


        }
    }

   
}
