using System;
using System.Collections.Generic;
using System.Text;

namespace CreateList.Collections
{
    public class MyList<T>
    {
        private T[] arr;
        public int count { get; set; }
        public MyList()
        {
            arr = new T[10];
        }

        public void AddRange(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Add(item);
            }
        }

        public void Add(T obj)
        {
            if ((count != 0) && (count % 10 == 0))
            {
                ArrayResize();
            }
            arr[count] = obj;
            count++;
        }

        private void ArrayResize()
        {
            Array.Resize(ref arr, arr.Length + 10);
        }

        public void Clear()
        {
            arr = new T[10];
            count = 0;
        }

        public T Find(Predicate<T> func)
        {
            foreach (var item in arr)
            {
                if (func(item))
                {
                    return item;
                }
            }
            return default;
        }

        public bool Contains(T obj)
        {
            foreach (var item in arr)
            {
                if (Comparer<T>.Default.Compare(item, obj) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Remove(T obj)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (Comparer<T>.Default.Compare(arr[i], obj) == 0)
                {
                    arr[i] = default;
                    count--;
                    return true;

                }

            }
            return false;
        }
        public int LastIndexOf(T obj)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (Comparer<T>.Default.Compare(arr[i], obj) == 0)
                {
                    return i;
                }
            }
            return -1;
        }


        public int IndexOf(T obj)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (Comparer<T>.Default.Compare(arr[i], obj) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}