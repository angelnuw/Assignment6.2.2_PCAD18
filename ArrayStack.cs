using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._2._2
{
    class ArrayStack
    {
        //integer array to store items
        private int[] items;
        //an integer top index start at -1
        private int top;
        //a default capacity constant
        private const int DefaultCapacity = 10;

        //constructor logic
        public ArrayStack(int capacity = DefaultCapacity)
        {
            if (capacity < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be greater than zero.");
            }
            items = new int[capacity];
            top = -1;
        }
        //empty stack check
        public bool IsEmpty() => top == -1;

        //push method to add an item
        public void Push(int item)
        {
            //check if the stack is full
            if (top == items.Length - 1)
            {
                //if full, double the size of the array
                int[] newItems = new int[items.Length * 2];
                Array.Copy(items, newItems, items.Length);
                items = newItems;
            }
            //increment top and add item
            items[++top] = item;
        }
        //pop method to remove an item
        public int Pop()
        {
            //check if the stack is empty
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            //return the item at the top and decrement top
            return items[top--];
        }
        public int Peek()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return items[top];
        }
    }

}
