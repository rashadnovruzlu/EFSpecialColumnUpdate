using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace EFSpecialColumnUpdate
{
    public static class EFContextExtensions
    {
        public static void UpdateSelectedValues<TEntity>(this DbContext context, TEntity entity,
                                                        params Expression<Func<TEntity, object>>[] properties) where TEntity : class
        {
            var entry = context.Entry(entity);

            entry.State = EntityState.Unchanged;

            foreach (var prop in properties)
            {
                entry.Property(prop).IsModified = true;
            }
        }
    }
}
