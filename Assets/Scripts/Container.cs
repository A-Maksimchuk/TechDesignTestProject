using System;
using System.Collections.Generic;

public static class Container
{
    private static Dictionary<Type, object> _bindObjects = new Dictionary<Type, object>();
    
    public static void Bind<T>(T obj) where T:class
    {
        Type t = typeof(T);
        if (_bindObjects.ContainsKey(t))
        {
            _bindObjects[t] = obj;
        }
        else
        {
            _bindObjects.Add(t, obj);
        }
    }

    public static T Get<T>()where T:class
    {
        Type t = typeof(T);
        if (_bindObjects.ContainsKey(t))
        {
            return _bindObjects[t] as T;
        }

        return null;
    }
}