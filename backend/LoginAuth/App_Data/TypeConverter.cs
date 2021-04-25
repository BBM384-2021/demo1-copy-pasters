using System.Linq;
using System.Reflection;
using Microsoft.Extensions.FileSystemGlobbing.Internal;

namespace LoginAuth.App_Data
{
    public static class TypeConverter
    {
        public static TTarget Convert<TSource, TTarget>(TSource source) where TTarget: class, new()
        {
            TTarget result = new TTarget();
            typeof(TSource).GetProperties().ToList().ForEach(p =>
            {
                PropertyInfo property = typeof(TTarget).GetProperty(p.Name);
                property.SetValue(result, p.GetValue(source));
            });
            return result;
        } 
    }
}