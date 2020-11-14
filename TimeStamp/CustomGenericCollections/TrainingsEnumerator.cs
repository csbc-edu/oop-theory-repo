using System;
using System.Collections.Generic;
using System.Text;

namespace CustomGenericCollections
{
    public class TrainingsEnumerator<T> : IEnumerator<T> where T : Training
    {
        private readonly TrainingsCollection<T> collection;
        public int Counter = -1;

        public TrainingsEnumerator(TrainingsCollection<T> collection)
        {
            this.collection = collection;
        }

        public object Current => collection[Counter];

        T IEnumerator<T>.Current => collection[Counter];

        public void Dispose()
        {
            Counter = -1;
        }

        public bool MoveNext()
        {
            ++Counter;
            if (collection.Count > Counter)
            {
                return true;
            }

            return false;
        }

        public void Reset()
        {
            Counter = -1;
        }
    }
}
