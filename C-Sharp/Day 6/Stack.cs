using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Stack<T> where T: notnull
    {
        T[] data;
        int top;
        public Stack(int size = 5)
        {
            data = new T[size];
            top = 0;
        }

        public void Push(T item)
        {
            //data[top] = item;
            //top++;
            if (top >= data.Length)
            {
                throw new Exception("Out of boundries exception");
            }
            data[top++] = item;
        }

        public T Pop()
        {
            //top--;
            //return data[top];
            if (top <= 0)
            {
                throw new Exception("No more elements");
            }
            T popedValue = data[top - 1];
            data[top] = default;
            top--;
            return popedValue;
        }

        public T Peek()
        {
            return data[top-1];
        }

        public bool Pop(out T val)
        {
            //top--;
            //return data[top];
            if (top <= 0)
            {
                val = default;
                return false;
            }
            val = data[top - 1];
            data[top] = default;
            top--;
            return true;
        }

        public int Count()
        {
            return top;
        }

        public T[] GetData()
        {
            Console.WriteLine($"top = {top}");
            return data;
        }
    }
    //class Stack
    //{
    //    int[] data;
    //    int top;
    //    public Stack(int size = 5)
    //    {
    //        data = new int[size];
    //        top = 0;
    //    }

    //    public void Push(int item)
    //    {
    //        //data[top] = item;
    //        //top++;
    //        if (top >= data.Length)
    //        {
    //            throw new Exception("Out of boundries exception");
    //        }
    //        data[top++] = item;
    //    }

    //    public int Pop()
    //    {
    //        //top--;
    //        //return data[top];
    //        if (top <= 0)
    //        {
    //            throw new Exception("No more elements");
    //        }
    //        int popedValue = data[top - 1];
    //        data[top] = 0;
    //        top--;
    //        return popedValue;
    //    }

    //    //public bool Pop(out int val)
    //    //{
    //    //    //top--;
    //    //    //return data[top];
    //    //    if (top <= 0)
    //    //    {
    //    //        val = 0;
    //    //        return false;
    //    //    }
    //    //    val = data[top - 1];
    //    //    data[top] = 0;
    //    //    top--;
    //    //    return true;
    //    //}

    //    public int Count()
    //    {
    //        return top;
    //    }

    //    public int[] GetData()
    //    {
    //        return data;
    //    }
    //}
}
