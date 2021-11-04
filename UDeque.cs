namespace CustomGenerics
{
    /// <summary>
    /// Represents a custom-made Deck object. Made by Un1ver5e!
    /// </summary>
    /// <typeparam name="T">Type of items in this Stack.</typeparam>
    public sealed class UDeque<T> : UTwoLinkedList<T>
    {

        /// <summary>
        /// Return the left bound of the deck without removing it.
        /// </summary>
        /// <returns>The left bound of the deck.</returns>
        public T Right() => GetLast();

        /// <summary>
        /// Return the right bound of the deck without removing it.
        /// </summary>
        /// <returns>The right bound of the deck.</returns>
        public T Left() => GetFirst();

        /// <summary>
        /// Takes the the right bound of the deck.
        /// </summary>
        /// <returns>the right bound of the stack.</returns>
        public T TakeRight() => TakeLast();

        /// <summary>
        /// Takes the the left bound of the deck.
        /// </summary>
        /// <returns>the left bound of the stack.</returns>
        public T TakeLeft() => TakeFirst();

        /// <summary>
        /// Places given object to the right bond of the deck.
        /// </summary>
        /// <param name="item">The object to place.</param>
        public void PlaceRight(T item) => PlaceLast(item);

        /// <summary>
        /// Places given object to the left bond of the deck.
        /// </summary>
        /// <param name="item">The object to place.</param>
        public void PlaceLeft(T item) => PlaceFirst(item);

        /// <summary>
        /// Checks whether the deck contains elements.
        /// </summary>
        /// <returns>True if deck contains no elements, otherwise false.</returns>
        public override bool IsEmpty() => base.IsEmpty();

        /// <summary>
        /// Returns the string representation of the deck, starting with the left bond.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => base.ToString();

        public UDeque(params T[] collection)
        {
            foreach (T item in collection)
            {
                PlaceLast(item);
            }
        }

        public UDeque(System.Collections.Generic.IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                PlaceLast(item);
            }
        }
    }
}
