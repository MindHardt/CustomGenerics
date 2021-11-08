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
        public UTwoLinkedList<T> Reverse(UTwoLinkedList<T> list)
        {
            var newList = new UStack<T>();
            while (!list.IsEmpty())
                newList.Push(list.TakeLast());
            
            return newList;
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
        public int CountUnique(UTwoLinkedList<T> list)
        {
            var count = 0;
            var elements = new UStack<T>();
            foreach (var e in list) {
                foreach (var el in elements) {
                    if (!ContainsElement(elements, el)) {
                        count++;
                        elements.Push(e);
                    }
                }
            }
            
            return count;
        }
        /// <summary>
        /// The function that checks if the element contains a list
        /// </summary>
        private bool ContainsElement(UTwoLinkedList<T> list, T element)
        {
            foreach (var el in list)
                if (el.Equals(element)) return true;
            
            return false;
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
        public UTwoLinkedList<int> InsertItselfAfter(UTwoLinkedList<int> list, int x)
        {
            var stack = new UStack<int>();
            foreach (var e in list) {
                stack.Push(e);
                if (e == x) 
                    foreach (var el in list) stack.Push(el);
            }
            return list;
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
        public UTwoLinkedList<T> RemoveAll(UTwoLinkedList<T> list, T item)
        {
            var newList = new UStack<T>();
            foreach (var el in list) 
                if (!el.Equals(item)) newList.Push(el);
            
            return newList;
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
            foreach (var e in second) first.PlaceLast(e);
            return first;
        }

        /// <summary>
        /// Task 10: Splits two Lists of integers on the first occurance of a specified number.
        /// </summary>
        /// <param name="list">A list to split</param>
        /// <param name="x">A number to split on. If not present in List, returns a tuple of the given list and an empty list.</param>
        public static Tuple<UTwoLinkedList<int>, UTwoLinkedList<int>> Split(UTwoLinkedList<int> list, int x)
        {

        }

        ///<summary>
        /// Task 11: Doubles the list, adding itself to its end.
        /// </summary>
        public UTwoLinkedList<T> Double(UTwoLinkedList<T> list)
        {
            var newList = new UStack<T>();
            foreach (var e in list) newList.Push(e);
            foreach (var e in list) newList.Push(e);

            return newList;
        }

        /// <summary>
        /// Task 12: Changes positions of two given items.
        /// </summary>
        public void Swap(T first, T second)
        {

        }
    }
}
