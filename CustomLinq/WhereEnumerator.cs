using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinq
{
    class WhereEnumerator<T> : IIteratable<T>,IEnumerator<T>
    {
        private IIteratable<T> _sourceIteratable;
        private Func<T, bool> _predicate;
        private IEnumerator<T> _sourceIEnumerator;
        private T _current;
        public WhereEnumerator(IIteratable<T> sourceIteratable,Func<T,bool> predicate)
        {
            _sourceIteratable = sourceIteratable;
            _sourceIEnumerator = sourceIteratable.GetEnumerator();
            _predicate = predicate;
        }
        public T Current => _current;

        object IEnumerator.Current => Current;

        public void add(T el)
        {
            
        }

        public void Dispose()
        {
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            while (_sourceIEnumerator.MoveNext())
            {
                if (_predicate(_sourceIEnumerator.Current))
                {
                    _current = _sourceIEnumerator.Current;
                    return true;
                }
            }

            return false;
        }

        public void Reset()
        {
            ;
        }
    }
}
