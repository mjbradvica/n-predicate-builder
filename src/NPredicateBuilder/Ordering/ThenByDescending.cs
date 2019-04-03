﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Ordering
{
    public class ThenByDescending<T, TKey> : IOrder<T>
    {
        private readonly Expression<Func<T, TKey>> _orderExpression;

        public ThenByDescending(Expression<Func<T, TKey>> orderExpression)
        {
            _orderExpression = orderExpression;
        }

        public IOrderedQueryable<T> Order(IQueryable<T> queryable)
        {
            var asOrdered = (IOrderedQueryable<T>)queryable;

            return asOrdered.ThenByDescending(_orderExpression);
        }
    }
}
