using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinq
{
    public interface IIteratable<T> 
    {
        IEnumerator<T> GetEnumerator();
        void add(T el);
    }
    
}
