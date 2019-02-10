using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinq
{
    class CollectionIEnumerator<T> : IEnumerator<T>
    {
        private List<T> _list;
        private int _current = -1;
        public CollectionIEnumerator(List<T> list)
        {
            _list = list;
        }

        public T Current
        {
            get
            {
                try
                {
                    return _list[_current];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }


        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            _current++;
            return _current < _list.Count;
        }

        public void Reset()
        {
            _current = -1;
        }
    }
}
