using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace SpinTheWheel
{
    /// <summary>
    /// Supports a simple iteration over a CircularLinkedList<T>.
    /// </summary>
    /// <typeparam name="T">The type of objects to enumerate.</typeparam>
    public class CircularLinkedListEnumerator<T> : IEnumerator<T>
    {
        private LinkedListNode<T>? _current;

        public T Current => _current is not null 
            ? _current.Value 
            : throw new SystemException($"Unexpected null value for {nameof(_current)}");
        object? IEnumerator.Current => Current;

        /// <summary>
        /// Create a CircularLinkedListEnumerator<T> from a CircularLinkedList<T>.
        /// </summary>
        /// <param name="list">The list to enumerate over.</param>
        public CircularLinkedListEnumerator(CircularLinkedList<T> list) => _current = list.Last;

        public void Dispose() => GC.SuppressFinalize(this); 

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public bool MoveNext()
        {
            bool result = false;
            if (_current is not null)
            {
                _current = _current?.Next ?? _current?.List?.First;
                result = true;
            }

            return result;
        }

        public void Reset() => _current = _current?.List?.Last;
    }
}