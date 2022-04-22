using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GodotModules 
{
    public static class ReflectionUtils 
    {
        public static Dictionary<TKey, TValue> LoadInstances<TKey, TValue>(string prefix) =>
            Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => typeof(TValue).IsAssignableFrom(x) && !x.IsInterface)
                .Select(Activator.CreateInstance).Cast<TValue>()
                .ToDictionary(x => (TKey)Enum.Parse(typeof(TKey), x.GetType().Name.Replace(prefix, "")), x => x);

        /*public static Dictionary<Key, Value> LoadInstances<Key, Value, Namespace>() =>
            Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => typeof(Value).IsAssignableFrom(x) && !x.IsAbstract && x.Namespace == typeof(Namespace).Namespace)
                .Select(Activator.CreateInstance).Cast<Value>()
                .ToDictionary(x => (Key)Enum.Parse(typeof(Key), x.GetType().Name.Replace(typeof(Value).Name, "")), x => x);*/
    }
}