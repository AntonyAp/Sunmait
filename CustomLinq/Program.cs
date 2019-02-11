using System;

namespace CustomLinq
{
    class Program 
    {
        static void Main(string[] args)
        {
            CustomList<int> p = new CustomList<int>(5,5,7,8,9,70);
            p.Add(44);
            var res = p.Filter(x => x > 50);
            foreach (var f in res)
            {
                Console.WriteLine(f);
            }
        }
    }
}
