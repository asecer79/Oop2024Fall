using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w09
{
    public class MySpecialCollection<T>:ICollection<T>
    {
        List<T> list = new List<T>();
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.list)
            {
                yield return item;
            }
        }

       public List<T> FindAll(Func<T, bool> filter)
        {
            var filtered = new List<T>();

            foreach (var item in this.list)
            {
                if (filter(item))
                {
                    filtered.Add(item);
                }
            }
            
            return filtered;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
           list.Add(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            return list.Remove(item);
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
    }
}
