using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace AlgorithmsAndDataStructures.LinearDataStructures
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }

        public Node() {}
    }
    
    public class DoublyLinkedList<T>
    {
        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }
        public int Size { get; set; }

        public DoublyLinkedList()
        {
            First = null;
            Last = null;
            Size = 0;
        }

        /**
         * Iterate through the list until callback returns a truthy value
         * @example see #Get and #IndexOf
         * @param {Function} callback evaluates current node and index and returns a node position
         */
        public int Find(Func<Node<T>, int, int> callback)
        {
            var current = First;
            var position = 0;
            while (current != null)
            {
                var result = callback(current, position);
                if (result != -1) return result;
                
                position++;
                current = current.Next;
            }

            return -1;
        }
        
        /**
         * Iterate through the list until callback returns a truthy value
         * @example see #Get and #IndexOf
         * @param {Function} callback evaluates current node and index and returns a Node object
         */
        public Node<T> Find(Func<Node<T>, int, Node<T>> callback)
        {
            var current = First;
            var position = 0;
            while (current != null)
            {
                var result = callback(current, position);
                if (result != null) return result;
                
                position++;
                current = current.Next;
            }

            return null;
        }

        /**
         * Search by value. It finds first occurrence of
         * the element matching the value.
         * Runtime: O(n)
         * @example: assuming a linked list with: a -> b -> c * linkedList.indexOf('b') // ↪️ 1
         * linkedList.indexOf('z') // ↪️ undefined
         * @param {any} value
         * @returns {number} return index or undefined
         */
        public int IndexOf(T value)
        {
            return Find((current, position) =>
            {
                if (current.Value.Equals(value))
                {
                    return position;
                }

                return -1;
            });
        }

        /**
         * Search by index
         * Runtime: O(n)
         * @example: assuming a linked list with: a -> b -> c
         * */
        public Node<T> Get(int index = 0)
        {
            return Find((current, position) => position == index ? current : null);
        }

        /**
         * Adds element to the begining of the list. Similar to Array.unshift * Runtime: O(1)
         * @param {any} value
         * Runtime: O(1)
         */
        public Node<T> AddFirst(T value)
        {
            var newNode = new Node<T>(value);
            newNode.Next = First;

            if (First != null)
            {
                First.Previous = newNode;
            }
            else
            {
                Last = newNode;
            }

            First = newNode;
            Size++;

            return newNode;
        }

        /**
         * Adds element to the end of the list (tail). Similar to Array.push * Using the element last reference instead of navigating through the
         * list,
         * we can reduced from linear to a constant runtime.
         * Runtime: O(1)
         */
        public Node<T> AddLast(T value)
        {
            var newNode = new Node<T>();

            if (First != null)
            {
                newNode.Previous = Last;
                Last.Next = newNode;
                Last = newNode;
            }
            else
            {
                First = newNode;
                Last = newNode;
            }

            Size++;

            return newNode;
        }

        /**
         * Insert new element at the given position (index)
         * Runtime: ???
         */
        public Node<T> Add(T value, int position = 0)
        {
            if (position == 0)
            {
                AddFirst(value);
            }

            if (position == Size)
            {
                AddLast(value);
            }

            var current = Get(position);
            if (current != null)
            {
                var newNode = new Node<T>(value);
                newNode.Previous = current.Previous;
                newNode.Next = current;

                current.Previous.Next = newNode;
                current.Previous = newNode;

                Size++;
                return newNode;
            }

            return null;
        }

        public T RemoveFirst()
        {
            var head = First;
            if (head != null)
            {
                First = head.Next;
                if (First != null)
                {
                    First.Previous = null;
                }
                else
                {
                    Last = null;
                }

                Size--;
            }

            return head.Value;
        }
        
    }
}