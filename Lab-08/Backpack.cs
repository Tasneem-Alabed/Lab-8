using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lab_08
{
    public class Backpack<T> : IBag<T>
    {
        private List<T> lists;

        public Backpack()
        {
            lists = new List<T>();
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in lists)
            {
                yield return item;
            }
        }

        public void Pack(T item)
        {
            lists.Add(item);
        }

        public T Unpack(int index)
        {
            var b = lists[index];
            lists.RemoveAt(index);
            return b;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in lists)
            {
                yield return item;
            }
        }
    }
}
