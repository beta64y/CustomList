using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList.Exceptions;

namespace CustomList
{
    internal class GenericList<K> : IEnumerable
    {
        K[] List = new K[0];
        public int Count { get; set; } = 0;
        private int _capacity; 

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; } 
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            K[] arr = new K[Count];
            for (int i = 0; i < Count; i++)
            {
                arr[i] = List[i];
            }
            return arr.GetEnumerator();
        }
        public GenericList()
        {
            Capacity = 0;
        }
        public GenericList(int capacity)
        {
            Capacity = capacity;
            Array.Resize(ref List, Capacity);
        }
        public void Add(K item)
        {
            if (Capacity == 0)
            {
                Capacity = 4;
                Array.Resize(ref List, Capacity);
            }
            else if (Count == Capacity)
            {
                Capacity *= 2;
                Array.Resize(ref List, Capacity);
            }
            List[Count] = item;
            Count++;


        }
        public K Find(Predicate<K> mathch)
        {
            for (int i = 0; i < Count; i++)
            {
                if (mathch(List[i]))
                {
                    return List[i];
                }
            }
            throw new NotFoundException("axtarilan tapilmadi");
        }
        public GenericList<K> FindAll(Predicate<K> mathch)
        {
            GenericList<K> result = new();
            int resultCount = 0;
            for (int i = 0; i < Count; i++)
            {
                if (mathch(List[i]))
                {
                    result.Add(List[i]);
                    
                }
            }
            return result;
            
        }
        public bool Contains(K item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (List[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        public bool Exists(Predicate<K> mathch)
        {
            for (int i = 0; i < Count; i++)
            {
                if (mathch(List[i]))
                {
                    return true;
                }
            }
        return false;
        }
        public void Remove(K item)
        {
            int controler= 0;
            for (int i = 0; i < Count; i++)
            {
                if (List[i].Equals(item))
                {
                    controler = i;
                }
            }
            for (int i = controler; i < Count-1; i++)
            {
                List[i] = List[i+1];
            }
            List[Count-1] = default(K);
            Count--;

        }

    }
}
