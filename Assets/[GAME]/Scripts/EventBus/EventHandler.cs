using System;
using UnityEngine;

public class EventHandler
{
    private event Action _eventHandler = delegate { };

    public void AddListener(Action action)
    {
        _eventHandler -= action;
        _eventHandler += action;
    }

    public void RemoveListener(Action action)
    {
        _eventHandler -= action;
    }

    public void Invoke()
    {
        _eventHandler();
    }

    public void Clear()
    {
        _eventHandler = delegate { };
    }
}

public class EventHandler<T>
{
    private event Action<T> _eventHandler = delegate { };

    public void AddListener(Action<T> action)
    {
        _eventHandler -= action;
        _eventHandler += action;
    }

    public void RemoveListener(Action<T> action)
    {
        _eventHandler -= action;
    }

    public void Invoke(T obj)
    {
        _eventHandler(obj);
    }

    public void Clear()
    {
        _eventHandler = delegate { };
    }
}

public class EventHandler<T, U>
{
    private event Action<T, U> _eventHandler = delegate { };

    public void AddListener(Action<T, U> action)
    {
        _eventHandler -= action;
        _eventHandler += action;
    }

    public void RemoveListener(Action<T, U> action)
    {
        _eventHandler -= action;
    }

    public void Invoke(T obj1, U obj2)
    {
        _eventHandler(obj1, obj2);
    }

    public void Clear()
    {
        _eventHandler = delegate { };
    }
}
