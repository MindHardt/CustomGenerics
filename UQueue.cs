using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomGenerics
{
    /// <summary>
    /// Represents a custom-made Queue object. Made by Un1ver5e!
    /// </summary>
    /// <typeparam name="T">Type of items in this Stack.</typeparam>
    public class UQueue<T> : IEnumerable<T>
    {
        private TwoLinkedList<T> body;

        /// <summary>
        /// Return the end of the stack without removing it.
        /// </summary>
        /// <returns>The top of the stack.</returns>
        public T End() => body.GetLast();

        /// <summary>
        /// Takes the End of the queue.
        /// </summary>
        /// <returns>the top of the stack.</returns>
        public T Dequeue() => body.TakeFirst();

        /// <summary>
        /// Places given object to the beginning of the stack.
        /// </summary>
        /// <param name="item">The object to place.</param>
        public void Enqueue(T item) => body.PlaceLast(item);

        /// <summary>
        /// Checks whether the queue contains elements.
        /// </summary>
        /// <returns>True if the queue contains no elements, otherwise false.</returns>
        public bool IsEmpty() => body.IsEmpty();

        /// <summary>
        /// Returns the string representation of the queue, starting with the first element.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => body.ToString();

        /// <summary>
        /// Initializes an empty queue.
        /// </summary>
        public UQueue() => body = new TwoLinkedList<T>();

        /// <summary>
        /// Initializes a queue which contains the elements of given collection.
        /// </summary>
        /// <param name="collection">The original collection.</param>
        public UQueue(IEnumerable<T> collection) => body = new TwoLinkedList<T>(collection);

        /// <summary>
        /// Initializes a queue which contains the elements of given collection.
        /// </summary>
        /// <param name="collection">The original collection.</param>
        public UQueue(params T[] collection) => body = new TwoLinkedList<T>(collection);

        /// <summary>
        /// Gets the Enumerator object for this stack.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator() => body.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => body.GetEnumerator();
    }
}
