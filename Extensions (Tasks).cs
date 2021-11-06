using System;
using System.Collections.Generic;
using System.Text;

namespace CustomGenerics
{
    //Напоминаю что у списков реализован перебор через foreach!!
    
    
    /// <summary>
    /// This class contains extension methods for UTwoLinkedList aka Tasks 1..12.
    /// </summary>
    public abstract partial class UTwoLinkedList<T>
    {
        /// <summary>
        /// Task 1: Reverse the List, making its items go backwards.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void Reverse()
        {

        }

        /// <summary>
        /// Task 2: Move first element to last position.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void MoveFirstToLast()
        {

        }

        /// <summary>
        /// Task 2: Move last element to first position.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void MoveLastToFirst()
        {

        }

        /// <summary>
        /// Task 3: Count unique numbers in an integer List.
        /// </summary>
        public int CountUnique()
        {

        }

        /// <summary>
        /// Task 4: Remove the second of identical elements.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void RemoveSecondClone()
        {

        }

        /// <summary>
        /// Task 5: Insert List into itself after the first occurance of the number.
        /// </summary>
        /// <param name="x">The number to seek for.</param>
        public void InsertItselfAfter(int x)
        {

        }

        /// <summary>
        /// Task 6: Place item in List sorted by non-decreasing, not breaking the order (leaving it sorted).
        /// </summary>
        /// <param name="item">The item to place</param>
        public void PlaceRespectingOrder(T item)
        {

        }

        /// <summary>
        /// Task 7: Remove all occurances of the specified item within the List.
        /// </summary>
        /// <param name="item">The item to remove</param>
        public void RemoveAll(T item)
        {

        }

        /// <summary>
        /// Task 8: Place a new item before the first occurance of a specified item, it it is presented in the list.
        /// </summary>
        /// <param name="newItem">The new item to place.</param>
        /// <param name="existingItem">The old item before which to place, if it is presented.</param>
        public void RemoveAll(T newItem, T existingItem)
        {

        }

        /// <summary>
        /// Task 9: Concatenates two Lists of integer numbers. Only applicable for Lists of int32.
        /// </summary>
        /// <param name="first">A list lying before.</param>
        /// <param name="second">A list lying after.</param>
        public static UTwoLinkedList<int> Concat(UTwoLinkedList<int> first, UTwoLinkedList<int> second)
        {

        }

        /// <summary>
        /// Task 10: Splits two Lists of integers on the first occurance of a specified number.
        /// </summary>
        /// <param name="list">A list to split</param>
        /// <param name="x">A number to split on. If not present in List, returns a tuple of the given list and an empty list.</param>
        public static Tuple<UTwoLinkedList<int>, UTwoLinkedList<int>> Split(UTwoLinkedList<int> list, int x)
        {

        }

        /// <summary>
        /// Task 11: Doubles the list, adding itself to its end.
        /// </summary>
        public void Double()
        {

        }

        /// <summary>
        /// Task 12: Changes positions of two given items.
        /// </summary>
        public void Swap(T first, T second)
        {

        }
    }
}
