using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinTheWheel
{
    public static class CircularLinkedListExtensions
    {
        /// <summary>
        /// Get the next LinkedListNode<T> in the CircularLinkedList<T>.
        /// </summary>
        /// <typeparam name="T">The type of the object in the node.</typeparam>
        /// <param name="node">The current LinkedListNode<T>.</param>
        /// <returns></returns>
        public static LinkedListNode<T>? Next<T>(this LinkedListNode<T> node) 
            => node is null || node.List is null ? null : node.Next ?? node.List.First;

        /// <summary>
        /// Get the previous LinkedListNode<T> in the CircularLinkedList<T>.
        /// </summary>
        /// <typeparam name="T">The type of the object in the node.</typeparam>
        /// <param name="node">The current LinkedListNode<T>.</param>
        /// <returns></returns>
        public static LinkedListNode<T>? Previous<T>(this LinkedListNode<T> node)
            => node is null || node.List is null ? null : node.Previous ?? node.List.Last;
    }
}
