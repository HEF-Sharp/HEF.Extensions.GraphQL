namespace HEF.Extensions.GraphQL.EntityQuery
{
    public interface IEntityGraphQueryBuilderFactory
    {
        IEntityGraphQueryBuilder<TEntity> Create<TEntity>() where TEntity : class;
    }
}
