using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SharedLibrary
{
    public class Common
    {
        public enum FieldType
        {
            Number,
            String
        }

        public enum FilterOperators
        {
            LessThan,
            LessThanOrEqual,
            Equal,
            GreaterThan,
            GreaterThanOrEqual,
            Like,
            NotEqualTo
        }

        public static string BuildCondition(StringBuilder sb, string fieldName, string fieldVlaue, FilterOperators oprator)
        {
            if (fieldVlaue.Trim().Length == 0)
                return "";

            string expression = string.Empty;
            string op = GetOperatorString(oprator);

            if (oprator == FilterOperators.Like)
            {
                expression = fieldName + " LIKE '" + fieldVlaue.Trim().Replace("'", "''") + "%'";
            }
            else
            {
                expression = fieldName + op + "'" + fieldVlaue.Trim().Replace("'", "''") + "'";
            }
            if (sb.Length > 0)
            {
                return " AND " + expression.Trim();
            }
            else
            {
                return expression.Trim();
            }


        }

        public static string BuildConditionMultiFilter(string fieldName, string fieldVlaue)
        {
            string fval = "(";
            foreach (var item in Regex.Replace(fieldVlaue, @"\t|\n|\r", ",").Replace(",,", ",").Split(','))
                if (item != "")
                    fval = fval + " " + fieldName + " like '%" + item + "%' OR  ";

            if (fval == "(")
                fval = "";
            else
                fval = " and " + fval.Substring(0, fval.Length - 5) + ")";
            return fval;

        }


        public static string BuildConditionMultiFilterWithoutand(string fieldName, string fieldVlaue)
        {
            string fval = "(";
            foreach (var item in Regex.Replace(fieldVlaue, @"\t|\n|\r", ",").Replace(",,", ",").Split(','))
                if (item != "")
                    fval = fval + " " + fieldName + " like '%" + item + "%' OR  ";

            if (fval == "(")
                fval = "";
            else
                fval = fval.Substring(0, fval.Length - 5) + ")";
            return fval;

        }


        public static string BuildConditionSplit(string fieldVlaue)
        {
            string fval = "";
            foreach (var item in Regex.Replace(fieldVlaue, @"\t|\n|\r", ",").Replace(",,", ",").Split(','))
                if (item != "")
                    fval = fval + "," + item;

            if (fval == "")
                fval = "";
            else
                fval = fval.Substring(1);
            return fval;

        }
        /// <summary>
        /// Build the condition using the given parameter.
        /// </summary>
        /// <param name="sb">The source StringBuild Class.</param>
        /// <param name="fieldName">The name of the field.</param>
        /// <param name="fieldVlaue">Value of the field.</param>
        /// <param name="useOperator">Whether to use the default operator or user defined operator.</param>
        /// <returns>Returns output condition string.</returns>   
        public static string BuildCondition(StringBuilder sb, string fieldName, decimal fieldVlaue, FilterOperators oprator)
        {
            string expression = string.Empty;
            string op = GetOperatorString(oprator);

            expression = fieldName + op + fieldVlaue;

            if (sb.Length > 0)
            {
                return " AND " + expression.Trim();
            }
            else
            {
                return expression.Trim();
            }

        }

        private static string GetOperatorString(FilterOperators fo)
        {
            string outputString;
            switch (fo)
            {
                case FilterOperators.Equal:
                    outputString = "=";
                    break;
                case FilterOperators.GreaterThan:
                    outputString = ">";
                    break;
                case FilterOperators.GreaterThanOrEqual:
                    outputString = ">=";
                    break;
                case FilterOperators.LessThan:
                    outputString = "<";
                    break;
                case FilterOperators.LessThanOrEqual:
                    outputString = "<=";
                    break;
                case FilterOperators.Like:
                    outputString = " LIKE ";
                    break;
                case FilterOperators.NotEqualTo:
                    outputString = " <> ";
                    break;
                default:
                    outputString = "=";
                    break;
            }
            return outputString;
        }
    }
}
