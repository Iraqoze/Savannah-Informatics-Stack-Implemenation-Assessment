using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurStack
{

    #region  This is a generic class that contains items of the specified type
        //T represent our generic type
        //T Value is the generic value
        //Count is to keep track of the number of items
    #endregion

    public class OurStack<T>
    {
        private T[] Items;
        private T? Value;
        private int Count;
        public OurStack(int Length)
        {
            Items = new T[Length];
        }


        //Push
        public void Push(T value)
        {
            if (Count == Items.Length)
                throw new Exception("Stack Overflow");
            Items[Count++] = value;

        }
        //Peek
        public T Peek()
        {
            if (IsEmpty())
                throw new Exception("Empty Stack");
            return Items[Count - 1];
        }

        //Pop
        public T Pop()
        {
            if (IsEmpty())
                throw new Exception("Empty Stack");

            var item = Items[Count - 1];

            Items[Count - 1] = Value;
            Count--;
            return item;
        }

        //Is Empty
        public bool IsEmpty() => Count == 0;        

        //Count
        public int GetCount() => Count;

        //Contains
        public bool Contains(T value)
        {
            if(IsEmpty())
                return false;
            for (int i = 0; i < Count; i++)
            {
                if (value.Equals(Items[i]))
                    return true;
            }
            return false;
        }

        //Clear Stack
        public void Clear()
        {
            Count = 0;
            Items = null;
        }
        //Reverse the Stack
        public void Reverse()
        {
            var reversedStack = new T[Count];
            var index = 0;
            for (int i = Count-1; i >= 0; i--)
                reversedStack[index++] = Items[i];

            for (int i = 0; i < reversedStack.Length; i++)
                Items[i]=reversedStack[i];
                          
        }

        //To String
        public override string? ToString()
        {
            if (IsEmpty())
                return "";
            var sb = new StringBuilder();
            for (int i = 0; i < Count; i++)
                sb.Append($"{Items[i]}, ");
            
            return sb.ToString();
        }

        

    }
}
