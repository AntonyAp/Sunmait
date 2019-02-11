using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomLinq
{
    class MapEnumerator<T,S> :  IEnumerator<S>,IIteratable<S>
    {

        private IIteratable<T> _sourceIteratable;
        private Func<T, S> _selector;
        private IEnumerator<T> _sourceIEnumerator;
        private S _currenT;
        public MapEnumerator(IIteratable<T> sourceIteratable,Func<T,S> selector)
        {
            _sourceIteratable = sourceIteratable;
            _sourceIEnumerator = sourceIteratable.GetEnumerator();
            _selector = selector;
        }

        public S Current => _currenT;

        object IEnumerator.Current => Current;

        public void Add(S el)
        {
            
        }

        public void Dispose()
        {
            
        }

        public IEnumerator<S> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            while (_sourceIEnumerator.MoveNext())
            {
                _currenT = _selector(_sourceIEnumerator.Current);
                return true;
            }

            return false;
        }

        public void Reset()
        {
            
        }
    }
}
