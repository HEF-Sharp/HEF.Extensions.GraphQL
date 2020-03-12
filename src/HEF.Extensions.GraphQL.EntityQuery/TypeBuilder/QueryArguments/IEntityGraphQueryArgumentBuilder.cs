using GraphQL.Types;

namespace HEF.Extensions.GraphQL.EntityQuery
{
    public interface IEntityGraphQueryArgumentBuilder
    {
        QueryArgument Build<TEntity>() where TEntity : class;
    }
}
