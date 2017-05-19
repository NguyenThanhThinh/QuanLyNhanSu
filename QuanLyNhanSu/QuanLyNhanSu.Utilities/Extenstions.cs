using System;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;

namespace QuanLyNhanSu.Utilities
{
    public static class Extenstions
    {
        public static IQueryable<T> Including<T>(this IQueryable<T> self, params Expression<Func<T, object>>[] includeProperties) where T : class
        {
            return includeProperties.Aggregate(self, (current, includeProperty) => current.Include(includeProperty));
        }
    }
}
