using System.Collections;
using System.Collections.Generic;

namespace CustomGenerics
{
    class TwoLinkedListEnumerator<T> : IEnumerator<T>
    {
        private TwoLinkedList<T> body;
        private TwoLinkedList<T>.Node<T> currentElement;

        public T Current => currentElement.Content;

        object IEnumerator.Current => currentElement.Content;

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            currentElement = currentElement.Next;
            return currentElement != body.endpoint;
        }

        public void Reset() => currentElement = body.endpoint;

        public TwoLinkedListEnumerator(TwoLinkedList<T> body)
        {
            this.body = body;
            currentElement = body.endpoint;
        }
    }
}
