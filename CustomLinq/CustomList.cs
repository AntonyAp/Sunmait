using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinq
{
    public class CustomList<T> :IIteratable<T>
    {
        public   List<T> _list= new List<T>();

        public int Count(CustomList<T> list)
        {
            return _list.Count;
        }
        public void add(T el)
        {
            _list.Add(el);
        }
        public  IEnumerator<T> GetEnumerator()
        {
           return new CollectionIEnumerator<T>(_list);
        }
        
    }
}
