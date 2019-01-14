﻿
using System;
using System.Collections;
using System.Collections.Generic;

namespace UpDownMonitor
{
    internal static class CollectionHelpers
    {
        public static IReadOnlyCollection<T> ReifyCollection<T>(IEnumerable<T> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            IReadOnlyCollection<T> result = source as IReadOnlyCollection<T>;
            if (result != null)
            {
                return result;
            }
            ICollection<T> collection = source as ICollection<T>;
            if (collection != null)
            {
                return new CollectionWrapper<T>(collection);
            }
            return source is ICollection nongenericCollection ? new NongenericCollectionWrapper<T>(nongenericCollection) : (IReadOnlyCollection<T>)new List<T>(source);
        }

        private sealed class NongenericCollectionWrapper<T> : IReadOnlyCollection<T>
        {
            private readonly ICollection _collection;

            public NongenericCollectionWrapper(ICollection collection) => _collection = collection ?? throw new ArgumentNullException(nameof(collection));

            public int Count
            {
                get
                {
                    return _collection.Count;
                }
            }

            public IEnumerator<T> GetEnumerator()
            {
                foreach (T item in _collection)
                {
                    yield return item;
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => _collection.GetEnumerator();
        }

        private sealed class CollectionWrapper<T> : IReadOnlyCollection<T>
        {
            private readonly ICollection<T> _collection;

            public CollectionWrapper(ICollection<T> collection) => _collection = collection ?? throw new ArgumentNullException(nameof(collection));

            public int Count => _collection.Count;

            public IEnumerator<T> GetEnumerator() => _collection.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => _collection.GetEnumerator();
        }
    }
}
