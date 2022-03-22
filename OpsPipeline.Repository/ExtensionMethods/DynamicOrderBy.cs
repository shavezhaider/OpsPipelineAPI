using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace OpsPipelineAPI.Repository.ExtensionMethods
{
    public static class DynamicOrderBy
    {
        public static IEnumerable<T> OrderByDynamic<T>(this IEnumerable<T> source, string orderBy, ListSortDirection sortDirection)
        {
            if (sortDirection == ListSortDirection.Ascending)
                return source.OrderBy(x => GetPropertyValue(x, orderBy));
            else
                return source.OrderByDescending(x => GetPropertyValue(x, orderBy));
        }
        private static object GetPropertyValue(object obj, string property)
        {
            System.Reflection.PropertyInfo propertyInfo = obj.GetType().GetProperty(property);
            return propertyInfo.GetValue(obj, null);
        }
    }
}
