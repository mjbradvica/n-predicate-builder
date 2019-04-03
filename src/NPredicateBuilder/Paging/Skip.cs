﻿using System.Linq;

namespace NPredicateBuilder.Paging
{
    internal class Skip<T> : IMultipleFinalizer<T>
    {
        private readonly int _count;

        public Skip(int count)
        {
            _count = count;
        }

        public IQueryable<T> Finalize(IQueryable<T> queryable)
        {
            return queryable.Skip(_count);
        }
    }
}