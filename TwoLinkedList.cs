using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomGenerics
{

    public abstract class TwoLinkedList<T> : System.Collections.Generic.IEnumerable<T>
    {
        /// <summary>
        /// Represents en empty Node, located both in the beginning and the end of the list, making it loop.
        /// </summary>
        internal Node<T> endpoint = new Node<T>(default);

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


        internal T GetFirst() => first.Content;
        internal T GetLast() => last.Previous.Content;

        internal T TakeFirst() => first.SafeTake().Content;
        internal T TakeLast() => last.SafeTake().Content;

        internal void PlaceFirst(T item) => new Node<T>(item).PlaceBetween(endpoint, first);
        internal void PlaceLast(T item) => new Node<T>(item).PlaceBetween(last, endpoint);

        internal bool IsEmpty() => endpoint.Next == endpoint;

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
            internal Node<T> Previous;
            internal readonly T Content;
            internal Node<T> Next;

            /// <summary>
            /// Takes the element and redefines it's neighbours' references.
            /// </summary>
            /// <returns></returns>
            internal Node<T> SafeTake()
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
            internal void PlaceBetween(Node<T> previous, Node<T> next)
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
            internal Node(T content)
            {
                Content = content;
                Next = this;
                Previous = this;
            }
        }
    }
}
