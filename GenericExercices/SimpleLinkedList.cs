using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExercices
{
    public class SimpleLinkedList<T> : IEnumerable<T>
    {
        public SimpleLinkedList<T> Empty => throw new NotImplementedException();

        public void Add(T element) => throw new NotImplementedException();
        public void Add(T element, bool addInFront) => throw new NotImplementedException();

        public T GetElementAt(int index) => throw new NotImplementedException();

        public SimpleLinkedListNode<T> GetNodeAt(int index) => throw new NotImplementedException();

        public void InsertAt(int index, T element) => throw new NotImplementedException();

        public void RemoveAt(int index) => throw new NotImplementedException();

        public void InsertAfter(SimpleLinkedListNode<T> node, T element) => throw new NotImplementedException();

        public void InsertBefore(SimpleLinkedListNode<T> node, T element) => throw new NotImplementedException();
        
        public void Remove(SimpleLinkedListNode<T> node) => throw new NotImplementedException();

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int Count => throw new NotImplementedException();
    }
}
