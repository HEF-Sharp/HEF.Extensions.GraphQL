using GraphQL;

namespace HEF.Extensions.GraphQL.Server
{
    public interface IExecOptionsConfigHandler
    {
        void Configure(ExecutionOptions options);
    }
}
