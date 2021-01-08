using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinTheWheel
{
    /// <summary>
    /// Represents a circular linked list.
    /// </summary>
    /// <typeparam name="T">The type of the objects being stored.</typeparam>
    public class CircularLinkedList<T> : LinkedList<T>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the CircularLinkedList<T>.
        /// </summary>
        /// <returns>A CircularLinkedList<T>.Enumerator for the CircularLinkedList<T>.</returns>
        public new IEnumerator GetEnumerator() => new CircularLinkedListEnumerator<T>(this);
    }
}
