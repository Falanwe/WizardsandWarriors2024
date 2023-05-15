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
        private SimpleLinkedListNode<T>? _head = null;

        public T? this[int index]
        {
            get => GetElementAt(index);
            set
            {
                var node = GetNodeAt(index);
                if(node != null)
                {
                    node.Value = value;
                }
                else
                {
                    Add(value);
                }
            }
        }

        public void Add(T? element)
        {
            var newNode = new SimpleLinkedListNode<T>(element);
            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                var current = _head;
                while (current.NextNode != null)
                {
                    current = current.NextNode;
                }
                current.NextNode = newNode;
            }
        }
        public void Add(T? element, bool addInFront)
        {
            if (addInFront)
            {
                var newNode = new SimpleLinkedListNode<T>(element);
                newNode.NextNode = _head;
                _head = newNode;
            }
            else
            {
                Add(element);
            }
        }

        public T? GetElementAt(int index)
        {
            return GetNodeAt(index).Value;
        }

        public SimpleLinkedListNode<T>? GetNodeAt(int index)
        {
            var current = _head;
            for (var i = 0; i < index; i++)
            {
                current = current.NextNode;
            }

            return current;
        }

        public void InsertAt(int index, T element)
        {
            if (index == 0)
            {
                Add(element, true);
            }
            else
            {
                var previousNode = GetNodeAt(index - 1);
                var newNode = new SimpleLinkedListNode<T>(element);
                newNode.NextNode = previousNode.NextNode;
                previousNode.NextNode = newNode;
            }
        }

        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                _head = _head.NextNode;
            }
            else
            {
                var previousNode = GetNodeAt(index - 1);
                previousNode.NextNode = previousNode.NextNode.NextNode;
            }
        }

        public void InsertAfter(SimpleLinkedListNode<T> node, T element)
        {
            var newNode = new SimpleLinkedListNode<T>(element);
            newNode.NextNode = node.NextNode;
            node.NextNode = newNode;
        }

        public void InsertBefore(SimpleLinkedListNode<T> node, T element)
        {
            var newNode = new SimpleLinkedListNode<T>(element);
            newNode.NextNode = node;
            if (node == _head)
            {
                _head = newNode;
            }
            else
            {
                var current = _head;
                while (current.NextNode != node)
                {
                    current = current.NextNode;
                }
                current.NextNode = newNode;
            }
        }

        public void Remove(SimpleLinkedListNode<T> node)
        {
            if (node == _head)
            {
                _head = node.NextNode;
            }
            else
            {
                var current = _head;
                while (current.NextNode != node)
                {
                    current = current.NextNode;
                }
                current.NextNode = node.NextNode;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var current = _head; current != null; current = current.NextNode)
            {
                yield return current.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count
        {
            get
            {
                if (_head == null)
                {
                    return 0;
                }
                else
                {
                    var current = _head;
                    var result = 1;
                    while (current.NextNode != null)
                    {
                        current = current.NextNode;
                        result++;
                    }
                    return result;
                }
            }
        }
    }
}
