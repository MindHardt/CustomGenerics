using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomGenerics
{
    internal class TwoLinkedList<T> : System.Collections.Generic.IEnumerable<T>
    {
        /// <summary>
        /// Represents en empty Node, located both in the beginning and the end of the list, making it loop.
        /// </summary>
        internal Node<T> endpoint = new Node<T>(badContent);

        internal static T badContent
        {
            get => throw new ArgumentException("Collecion empty");
        }

        /// <summary>
        /// Represents the first element of the list.
        /// </summary>
        internal Node<T> first
        {
            get => endpoint.Next;
        }

        /// <summary>
        /// Represents the last element of the list.
        /// </summary>
        internal Node<T> last
        {
            get => endpoint.Previous;
        }


        public T GetFirst() => first.Content;
        public T GetLast() => last.Previous.Content;

        public T TakeFirst() => first.SafeTake().Content;
        public T TakeLast() => last.SafeTake().Content;

        public void PlaceFirst(T item) => new Node<T>(item).PlaceBetween(endpoint, first);
        public void PlaceLast(T item) => new Node<T>(item).PlaceBetween(last, endpoint);

        public bool IsEmpty() => endpoint.Next == endpoint;

        public TwoLinkedList(params T[] collection)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                PlaceLast(collection.ElementAt(i));
            }
        }

        public TwoLinkedList(IEnumerable<T> collection)
        {
            for (int i = 0; i < collection.Count(); i++)
            {
                PlaceLast(collection.ElementAt(i));
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node<T> item = first;
            while (item != endpoint)
            {
                sb.Append(item.Content.ToString() + "; ");
                item = item.Next;
            }
            return sb.ToString();
        }

        public IEnumerator<T> GetEnumerator() => new TwoLinkedListEnumerator<T>(this);

        IEnumerator IEnumerable.GetEnumerator() => new TwoLinkedListEnumerator<T>(this);

        internal class Node<T>
        {
            public Node<T> Previous;
            public T Content;
            public Node<T> Next;

            /// <summary>
            /// Takes the element and redefines it's neighbours' references.
            /// </summary>
            /// <returns></returns>
            public Node<T> SafeTake()
            {
                Previous.Next = Next;
                Next.Previous = Previous;
                return this;
            }

            /// <summary>
            /// Places the element between two other elements.
            /// </summary>
            /// <param name="previous"></param>
            /// <param name="next"></param>
            public void PlaceBetween(Node<T> previous, Node<T> next)
            {
                Next = next;
                Previous = previous;
                previous.Next = this;
                next.Previous = this;
            }

            /// <summary>
            /// Creates a Node with a specified content, referencing itself as its' neighbours.
            /// </summary>
            /// <param name="content"></param>
            public Node(T content)
            {
                Content = content;
                Next = this;
                Previous = this;
            }
        }
    }
}
