﻿using System.Linq.Expressions;

namespace WhereIfDemo
{
    public static class ExtentionMethods
    {
        public static IQueryable<TSource> WhereIf<TSource>
        (this IQueryable<TSource> source, bool condition, Expression<Func<TSource, bool>> predicate)
        {
            return condition ? source.Where(predicate) : source;
        }

        public static IEnumerable<TSource> WhereIf<TSource>
        (this IEnumerable<TSource> source, bool condition, Func<TSource, int, bool> predicate)
        {
            return condition ? source.Where(predicate) : source;
        }
    }
}
