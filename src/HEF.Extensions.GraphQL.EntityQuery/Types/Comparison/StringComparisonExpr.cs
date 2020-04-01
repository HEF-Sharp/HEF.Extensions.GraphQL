using GraphQL.Types;

namespace HEF.Extensions.GraphQL.EntityQuery
{
    public class StringComparisonExpr
    {
        public string _eq { get; set; }

        //public string _gt { get; set; }

        //public string _gte { get; set; }

        //public string _lt { get; set; }

        //public string _lte { get; set; }

        public bool? _is_null { get; set; }

        public string[] _in { get; set; }

        public string _neq { get; set; }

        public string[] _nin { get; set; }

        public string _prelike { get; set; }

        public string _like { get; set; }

        public string _suflike { get; set; }
    }

    public class StringComparisonExpr_Type : InputObjectGraphType
    {
        public StringComparisonExpr_Type()
        {
            Description = "expression to compare columns of type String. All fields are combined with logical 'AND'.";

            Field<StringGraphType>("_eq", "Equal");            
            Field<BooleanGraphType>("_is_null", "Is Null Or Not");
            Field<ListGraphType<NonNullGraphType<StringGraphType>>>("_in", "In");
            Field<StringGraphType>("_neq", "NotEqual");
            Field<ListGraphType<NonNullGraphType<StringGraphType>>>("_nin", "Not In");

            Field<StringGraphType>("_prelike", "StartsWith");
            Field<StringGraphType>("_like", "Contains");
            Field<StringGraphType>("_suflike", "EndsWith");
        }
    }
}
