using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w09
{
    public class Toy
    {
        public string Name { get; set; }

        public Toy(string name)
        {
            Name = name;
        }
    }

    public class ToyCollection: ICollection<Toy>
    {
        private List<Toy> toys = new List<Toy>();

        public IEnumerator<Toy> GetEnumerator()
        {
            foreach (var toy in this.toys)
            {
                yield return toy;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Toy item)
        {
            this.toys.Add(item);
        }

        public void Clear()
        {
            this.toys.Clear();
        }

        public bool Contains(Toy item)
        {
            return toys.Contains(item);
        }

        public void CopyTo(Toy[] array, int arrayIndex)
        {
            toys.CopyTo(array,arrayIndex);
        }

        public bool Remove(Toy item)
        {
           return toys.Remove(item);
        }

        public int Count=>toys.Count;
        public bool IsReadOnly { get; }
     
    }
}
