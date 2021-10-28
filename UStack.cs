using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomGenerics
{
    /// <summary>
    /// Represents a custom-made Stack object. Made by Un1ver5e!
    /// </summary>
    /// <typeparam name="T">Type of items in this Stack.</typeparam>
    public class UStack<T> : IEnumerable<T>
    {
        private TwoLinkedList<T> body;

        /// <summary>
        /// Return the top of the stack without removing it.
        /// </summary>
        /// <returns>The top of the stack.</returns>
        public T Peek() => body.GetLast();

        /// <summary>
        /// Takes the top of the stack.
        /// </summary>
        /// <returns>the top of the stack.</returns>
        public T Pop() => body.TakeLast();

        /// <summary>
        /// Places given object on the top of the stack.
        /// </summary>
        /// <param name="item">The object to place.</param>
        public void Push(T item) => body.PlaceLast(item);

        /// <summary>
        /// Checks whether the stack contains elements.
        /// </summary>
        /// <returns>True if the stack contains no elements, otherwise false.</returns>
        public bool IsEmpty() => body.IsEmpty();

        /// <summary>
        /// Returns the string representation of the stack, starting with the deepest lying elements.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => body.ToString();

        /// <summary>
        /// Initializes an empty stack.
        /// </summary>
        public UStack() => body = new TwoLinkedList<T>();

        /// <summary>
        /// Initializes a stack which contains the elements of given collection.
        /// </summary>
        /// <param name="collection">The original collection.</param>
        public UStack(IEnumerable<T> collection) => body = new TwoLinkedList<T>(collection);

        /// <summary>
        /// Initializes a stack which contains the elements of given collection.
        /// </summary>
        /// <param name="collection">The original collection.</param>
        public UStack(params T[] collection) => body = new TwoLinkedList<T>(collection);
            
        /// <summary>
        /// Gets the Enumerator object for this stack.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator() => body.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => body.GetEnumerator();
    }
}
