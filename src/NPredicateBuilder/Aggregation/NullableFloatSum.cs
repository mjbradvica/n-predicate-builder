﻿using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class NullableFloatSum : ISingleFinalizer<float?, float?>
    {
        public float? Finalize(IQueryable<float?> queryable) => queryable.Sum();
    }
}