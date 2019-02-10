using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinq
{
   public  static class LinqExtensions
    {
        public static IIteratable<T> Filter<T>(this IIteratable<T> source, Func<T, bool> predicate)
        {
            return new WhereEnumerator<T>(source,predicate);

            
        }

        public static IIteratable<S> Map<T,S>(this IIteratable<T> source, Func<T,S> selector)
        {
           
            return new MapEnumerator<T,S>(source,selector);
        }

        public static bool Some<T>(this IIteratable<T> source, Func<T, bool> predicate)
        {
            foreach (var element in source)
            {
                if (predicate(element))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool All<T>(this IIteratable<T> source, Func<T, bool> predicate)
        {
            foreach (var element in source)
            {
                if (!predicate(element))
                {
                    return false;
                }
            }

            return true;
        }


    }
}
