using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExercices
{
    public class SimpleLinkedListNode<T>
    {
        internal SimpleLinkedListNode(T? element)
        {
            Value = element;
        }

        public T? Value { get; internal set; }
        internal SimpleLinkedListNode<T>? NextNode { get; set; }
    }
}
