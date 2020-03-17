using GraphQL.Types;

namespace HEF.Extensions.GraphQL.EntityQuery
{
    public class ComparisonExpr<TStruct> where TStruct : struct
    {
        public TStruct? _eq { get; set; }

        public TStruct? _gt { get; set; }

        public TStruct? _gte { get; set; }

        public TStruct? _lt { get; set; }

        public TStruct? _lte { get; set; }

        public bool? _is_null { get; set; }

        public TStruct[] _in { get; set; }

        public TStruct? _neq { get; set; }

        public TStruct[] _nin { get; set; }
    }

    public abstract class ComparisonExpr_Type<TGraphType> : InputObjectGraphType
        where TGraphType : ScalarGraphType
    {
        public ComparisonExpr_Type()
        {
            Field<TGraphType>("_eq", "Equal");
            Field<TGraphType>("_gt", "GreaterThan");
            Field<TGraphType>("_gte", "GreaterThanOrEqual");
            Field<TGraphType>("_lt", "LessThan");
            Field<TGraphType>("_lte", "LessThanOrEqual");
            Field<BooleanGraphType>("_is_null", "Is Null Or Not");
            Field<ListGraphType<NonNullGraphType<TGraphType>>>("_in", "In");
            Field<TGraphType>("_neq", "NotEqual");
            Field<ListGraphType<NonNullGraphType<TGraphType>>>("_nin", "Not In");
        }
    }
}
