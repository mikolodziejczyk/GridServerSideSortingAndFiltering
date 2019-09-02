using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GridServerSideSortingAndFiltering.ExpressionList
{
    public enum FilterOperator
    {
        Contains,
        NotContains,
        Equals,
        NotEqual,
        StartsWith,
        EndsWith,
        LessThan,
        LessThanOrEqual,
        GreaterThan,
        GreaterThanOrEqual,
        InRange
    }
}