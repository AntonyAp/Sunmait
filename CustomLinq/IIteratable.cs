using System.Collections.Generic;

namespace CustomLinq
{
    public interface IIteratable<T> 
    {
        IEnumerator<T> GetEnumerator();
    }
    
}
