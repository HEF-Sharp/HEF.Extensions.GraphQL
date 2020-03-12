using GraphQL.Types;

namespace HEF.Extensions.GraphQL.EntityQuery
{
    public interface IEntityGraphQueryArgumentsBuilder
    {
        QueryArguments Build<TEntity>() where TEntity : class;
    }
}
