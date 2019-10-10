using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GridServerSideSortingAndFiltering.ExpressionList
{
    public static class AllowedOperators
    {
        public static FilterOperator[] OperatorsAllowedForString = new FilterOperator[] { FilterOperator.Contains, FilterOperator.Equals, FilterOperator.NotContains, FilterOperator.NotEqual, FilterOperator.StartsWith, FilterOperator.EndsWith };
        public static FilterOperator[] OperatorsAllowedForDate = new FilterOperator[] { FilterOperator.Equals, FilterOperator.NotEqual, FilterOperator.GreaterThan, FilterOperator.LessThan, FilterOperator.InRange };
        public static FilterOperator[] OperatorsAllowedForNumber = new FilterOperator[] { FilterOperator.Equals, FilterOperator.NotEqual, FilterOperator.GreaterThan, FilterOperator.GreaterThanOrEqual, FilterOperator.LessThan, FilterOperator.LessThanOrEqual, FilterOperator.InRange };
        public static FilterOperator[] OperatorsAllowedForBoolean = new FilterOperator[] { FilterOperator.Equals, FilterOperator.NotEqual };

        public static bool IsOperatorAllowedForString(FilterOperator filterOperator)
        {
            return OperatorsAllowedForString.Contains(filterOperator);
        }

        public static bool IsOperatorAllowedForDate(FilterOperator filterOperator)
        {
            return OperatorsAllowedForDate.Contains(filterOperator);
        }

        public static bool IsOperatorAllowedForNumber(FilterOperator filterOperator)
        {
            return OperatorsAllowedForNumber.Contains(filterOperator);
        }

        public static bool IsOperatorAllowedForBoolean(FilterOperator filterOperator)
        {
            return OperatorsAllowedForBoolean.Contains(filterOperator);
        }

        public static bool IsOperatorAllowedForType(FilterOperator filterOperator, Type type)
        {
            bool r = false;

            if (type == typeof(String))
            {
                r = IsOperatorAllowedForString(filterOperator);
            }

            if (type == typeof(DateTime) || type == typeof(DateTime?))
            {
                r = IsOperatorAllowedForDate(filterOperator);
            }

            if (type == typeof(Decimal) || type == typeof(Decimal?) || type == typeof(int) || type == typeof(int?) || type == typeof(double) || type == typeof(double?))
            {
                r = IsOperatorAllowedForNumber(filterOperator);
            }

            if (type == typeof(bool) || type == typeof(bool?) )
            {
                r = IsOperatorAllowedForBoolean(filterOperator);
            }

            return r;
        }
    }
}