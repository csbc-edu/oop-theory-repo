using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomGenericCollections
{
    public class TrainingsCollection<T> : ICollection<T> where T : Training
    {
        public TrainingsCollection()
        {
            List = new List<T>();
        }

        protected IList List { get; }

        public T this[int index] => (T)List[index];

        public int Count => this.List.Count;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            if (!string.IsNullOrEmpty(item.Name))
            {
                this.List.Add(item);
            }
        }

        public void Clear()
        {
            this.List.Clear();
        }

        public bool Contains(T item)
        {
            return this.List.Contains(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new TrainingsEnumerator<T>(this);
        }

        public bool Remove(T item)
        {
            if (item != null && Contains(item))
            {
                this.List.Remove(item);
                return true;
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new TrainingsEnumerator<T>(this);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            this.List.CopyTo(array, arrayIndex);
        }

        public void ForEach(Action<string> action)
        {
            foreach (var item in List.OfType<T>())
            {
                action($"Traning Name {item.Name} and cost {item.Cost}");
            }
        }
    }
}
