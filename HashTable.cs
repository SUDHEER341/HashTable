﻿using System;
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
        
    }
}