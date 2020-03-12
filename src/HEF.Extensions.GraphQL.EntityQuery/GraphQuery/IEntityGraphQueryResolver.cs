using GraphQL;
using System.Linq;

namespace HEF.Extensions.GraphQL.EntityQuery
{
    public interface IEntityGraphQueryResolver
    {
        IQueryable<TEntity> Resolve<TEntity>(IResolveFieldContext resolveContext) where TEntity : class;
    }
}
