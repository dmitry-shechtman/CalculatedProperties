using System;
using System.Reflection;

namespace CalculatedProperties.Internal
{
    internal static class TypeExtensions
    {
        public static Assembly GetAssembly(this Type type)
        {
            return type.Assembly;
        }
    }
}
