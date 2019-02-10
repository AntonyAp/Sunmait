using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinq
{
    class Program 
    {
        static void Main(string[] args)
        {
            IIteratable<int> p = new CustomList<int>();
            char k = '3';
            
            int i = (int) Char.GetNumericValue(k);
            Console.WriteLine(i);
            
            foreach (var f in p)
            {
                Console.WriteLine(f);
            }
        //    p.add(45);
        //    p.add(50);
        //    p.add(32);
            
        //    var k = p.Filter(x => x > 35);

        //    p.add(66);
        //    p.add(32);
        //    var go = p.Map(x => x * 10).Filter(x=>x>600);
        //    foreach (var l in go)
        //    {
        //        Console.WriteLine(l);
        //    }

        //    var any = p.Filter(x=>x>5).Some(x => x > 3);
        //    Console.WriteLine(any);
        }
    }
}
