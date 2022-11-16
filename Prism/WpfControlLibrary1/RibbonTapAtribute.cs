using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple =true)]
    public class DependentViewAtribute: Attribute
    {
        public string Region { get; set; }
        public Type Type { get; set; }
        public DependentViewAtribute(string region, Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));
            if (region is null)
                throw new ArgumentNullException(nameof(region));
            Type = type;
            Region = region;
        }
    }
}
