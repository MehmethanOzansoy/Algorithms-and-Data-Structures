using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Class1<T> : IEnumerable<T>, ICloneable
    {
        private T[] a;

        public int Capacity => a.Length;
        public int Count { get; private set; }

        public Class1() {
            
            a = new T[20];
            Count = 0;
        }

        public Class1(params T[] initial)
        {
            a = new T[initial.Length];
            Count++;
            foreach (var item in initial)
            {
                Add(item);
            }
        }

        public Class1(IEnumerable<T> collection)
        {
            a = new T[collection.ToArray().Length];
            Count= 0;
            foreach (var item in collection)
            {
                Add(item);
            }
        }


        public void Add(T item)
        {
            if (a.Length == Count)
                DoubleArray();


            a[Count] = item;
            Count++;
        }

        private void DoubleArray()
        {
           var temp = new T[a.Length *2];
           for (int i = 0; i < a.Length; i++)
            {
                temp[i] = a[i];
            }
           a = temp;
        }

        public T Remove()
        {
            if (Count == 0)
            {
                throw new Exception("There is no more item to be removed from the array");
            }

            if(a.Length/4 >= Count)
            {
                HalfArray();
            }
            
            var temp = a[Count-1];

            if(Count>0)
                Count--;

            return temp;
        }

        private void HalfArray()
        {
            if (a.Length > 2)
            {
                var temp = new T[a.Length/2];
                System.Array.Copy(a, temp, temp.Length);          
                a = temp;

                /*
                 *  for (int i=0; i<a.Length; i++)
                {
                    temp[i] = a[i];
                }
                 * Sytem.Array.Copy(a,temp,temp.Lenght)
                 */
            }
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return a.Take(Count).GetEnumerator();
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotSupportedException();
        }
    }
}
