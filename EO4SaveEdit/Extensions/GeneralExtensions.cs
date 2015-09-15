using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace EO4SaveEdit.Extensions
{
    public static class GeneralExtensions
    {
        public static T GetAttribute<T>(this ICustomAttributeProvider assembly, bool inherit = false) where T : Attribute
        {
            return assembly.GetCustomAttributes(typeof(T), inherit).OfType<T>().FirstOrDefault();
        }
    }
}
