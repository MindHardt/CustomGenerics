using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomGenerics
{
    /// <summary>
    /// Represents a custom-made Deck object. Made by Un1ver5e!
    /// </summary>
    /// <typeparam name="T">Type of items in this Stack.</typeparam>
    public class UDeck<T> : IEnumerable<T>
    {
        private TwoLinkedList<T> body;

        /// <summary>
        /// Return the left bound of the deck without removing it.
        /// </summary>
        /// <returns>The left bound of the deck.</returns>
        public T Right() => body.GetFirst();

        /// <summary>
        /// Return the right bound of the deck without removing it.
        /// </summary>
        /// <returns>The right bound of the deck.</returns>
        public T Left() => body.GetLast();

        /// <summary>
        /// Takes the the right bound of the deck.
        /// </summary>
        /// <returns>the right bound of the stack.</returns>
        public T TakeRight() => body.TakeLast();

        /// <summary>
        /// Takes the the left bound of the deck.
        /// </summary>
        /// <returns>the left bound of the stack.</returns>
        public T TakeLeft() => body.TakeFirst();

        /// <summary>
        /// Places given object to the right bond of the deck.
        /// </summary>
        /// <param name="item">The object to place.</param>
        public void PlaceRight(T item) => body.PlaceLast(item);

        /// <summary>
        /// Places given object to the left bond of the deck.
        /// </summary>
        /// <param name="item">The object to place.</param>
        public void PlaceLeft(T item) => body.PlaceLast(item);

        /// <summary>
        /// Checks whether the deck contains elements.
        /// </summary>
        /// <returns>True if deck contains no elements, otherwise false.</returns>
        public bool IsEmpty() => body.IsEmpty();

        /// <summary>
        /// Returns the string representation of the deck, starting with the left bond.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => body.ToString();

        /// <summary>
        /// Initializes an empty deck.
        /// </summary>
        public UDeck() => body = new TwoLinkedList<T>();

        /// <summary>
        /// Initializes a deck which contains the elements of given collection.
        /// </summary>
        /// <param name="collection">The original collection.</param>
        public UDeck(IEnumerable<T> collection) => body = new TwoLinkedList<T>(collection);

        /// <summary>
        /// Initializes a deck which contains the elements of given collection.
        /// </summary>
        /// <param name="collection">The original collection.</param>
        public UDeck(params T[] collection) => body = new TwoLinkedList<T>(collection);

        /// <summary>
        /// Gets the Enumerator object for this deck.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator() => body.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => body.GetEnumerator();
    }
}
