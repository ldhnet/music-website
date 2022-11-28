using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utility.Dependency
{
    /// <summary>
    /// 标记允许多重注入，即一个接口可以注入多个实例
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface)]
    public class MultipleDependencyAttribute : Attribute
    { }
}
