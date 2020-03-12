using GraphQL.Types;

namespace HEF.Extensions.GraphQL.EntityQuery
{
    public interface IEntityGraphTypeBuilder
    {
        ObjectGraphType<TEntity> Build<TEntity>() where TEntity : class;
    }
}
