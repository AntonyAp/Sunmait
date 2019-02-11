using System.Collections.Generic; 

namespace CustomLinq
{
    public class CustomList<T> :IIteratable<T>,ICustomList<T>
    {
        private List<T> _list;

        public CustomList(params T[] elements)
        {
            _list=new List<T>(elements);
        }
        public int Count(CustomList<T> list)
        {
            return _list.Count;
        }
        public void Add(T el)
        {
            _list.Add(el);
        }
        public  IEnumerator<T> GetEnumerator()
        {
           return new CollectionIEnumerator<T>(_list);
        }
    }
}
