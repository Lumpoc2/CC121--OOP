using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falmark___chapter_16
{
    public class customearrayList<T>
    {
        private T[] arr;
        private int count;

        public int Count
        {
            get
            {
                return this.count;
            }
        }
        private const int Intial_capacity = 4;

        public customearrayList(int capacity = Intial_capacity)
        {
            this.arr = new T[capacity];
            this.count = 0;
        }
        public void add(T item)
        {
            GrowIFArrIsFull();
            this.arr[this.count] = item;
            this.count++;

        }
        public void insert(int index, T item)
        {
            if (index > this.count || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid Index: " + index);

            }
            GrowIFArrIsFull();
            Array.Copy(this.arr, index, this.arr, index + 1, this.count - index);
            this.arr[index] = item;
            this.count++;
        }
        public void GrowIFArrIsFull()
        {
            if (this.count + 1 > this.arr.Length)
            {
                T[] extendarr = new T[this.arr.Length * 2];
                Array.Copy(this.arr, extendarr, this.count);
                this.arr = extendarr;
            }
        }
        public void clear()
        {
            this.arr = new T[Intial_capacity];
            this.count = 0;
        }
        public int indexOF(T item)
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (object.Equals(item, this.arr[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public bool contains(T item)
        {
            int index = indexOF(item);
            bool found = (index != -1);
            return found;
        }
        public T this[int index]
        {
            get
            {
                if (index >= this.count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("invalid index: " + index);

                }
                return this.arr[index];
            }
            set
            {
                if (index >= this.count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("invalid index: " + index);
                }
                this.arr[index] = value;
            }
        }
        public T RemoveAt(int index)
        {
            if (index >= this.count || index < 0)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid index: " + index);
            }
            T item = this.arr[index];
            Array.Copy(this.arr, index + 1,
             this.arr, index, this.count - index - 1);
            this.arr[this.count - 1] = default(T);
            this.count--;
            return item;
        }
        public int remove(T item)
        {
            int index = indexOF(item);
            if (index != -1)
            {
                this.RemoveAt(index);
            }
            return index;
        }
    }
}



    