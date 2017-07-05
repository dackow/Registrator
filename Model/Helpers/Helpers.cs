using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Helpers
{
    public class Helpers
    {
        public static Predicate<T> And<T>(params Predicate<T>[] predicates)
        {
            return delegate(T item)
            {
                foreach (Predicate<T> predicate in predicates)
                {
                    if (!predicate(item))
                    {
                        return false;
                    }
                }
                return true;
            };
        }

        public static bool CompareStrings(string s1, string s2, bool default_return_value)
        {
            if (string.IsNullOrEmpty(s1))
            {
                return default_return_value;
            }
            return string.Equals(s1, s2, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
