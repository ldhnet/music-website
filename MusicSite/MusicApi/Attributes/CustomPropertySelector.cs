using Autofac.Core;
using System.Reflection;

namespace MusicApi.Attributes
{
    public class CustomPropertySelector : IPropertySelector
    {
        public bool InjectProperty(PropertyInfo propertyInfo, object instance)
        {
            //判断那些属性是需要属性注入的
           return  propertyInfo.CustomAttributes.Any(c=>c.AttributeType == typeof(CustomSelectAttrbute));
        }
    }
}
