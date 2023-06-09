using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomHashTable
{
    internal class HashTable<T>
    {
        int count;

        public class Node<T>
        {
            public T Data;
            public Node<T> Next;

            public Node(T data)
            {
                Data = data;
            }
        }

        private Node<T> [] Values;
        public HashTable (int size)
        {
            Values = new Node<T>[size];
        }
        
        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            int arrayIndex = Math.Abs(value.GetHashCode()) % Values.Length;
            newNode.Next = Values[arrayIndex];
            Values[arrayIndex] = newNode;
        }

        public void Print()
        {
            for (int index = 0; index < Values.Length; index++)
            {
                Node<T> temp = Values[index];
                Console.Write("Index" + index + " :");
                while (temp != null)
                {
                    Console.Write(temp.Data + "-->");
                    temp = temp.Next;
                }
                Console.WriteLine();
            }
        }

        public void Delete(T value)
        {
            int arrayIndex = Math.Abs(value.GetHashCode()) % Values.Length;
            Node<T> temp = Values[arrayIndex];

            if (Values[arrayIndex] != null)
            {
                if (Values[arrayIndex].Data.Equals(value))
                {
                    Values[arrayIndex] = Values[arrayIndex].Next;
                }
            }

            if (temp != null)
            {
                if (temp.Data.Equals(value))
                {

                    Values[arrayIndex] = temp.Next;
                }
            }

        }

    }
}
