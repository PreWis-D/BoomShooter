using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class EventBusBase<T> where T : Enum
{
    protected Dictionary<T, EventHandler<T, object>> _eventHandlers = new();

    public EventBusBase()
    {
        var names = Enum.GetNames(typeof(T));

        foreach (var name in names)
            _eventHandlers.Add((T)Enum.Parse(typeof(T), name), new EventHandler<T, object>());
    }

    public void DispatchEvent(T e, object param1 = null)
    {
        if (!_eventHandlers.ContainsKey(e))
        {
            Debug.Log($"You're trying to dispatch an event {e} that is not tracked yet. Add it to dispatcher first.");
            return;
        }

        try
        {
            _eventHandlers[e].Invoke(e, param1);
        }
        catch (Exception exception)
        {
            Debug.LogError($"{e} dispatch thrown an exception {exception}. Param: {param1}");
        }
    }

    public void SubscribeTo(T e, Action<T, object> action)
    {
        if (!_eventHandlers.ContainsKey(e))
        {
            Debug.Log($"You're trying to subscribe to an event {e} that is not handled. Add it to dispatcher first.");
            return;
        }

        _eventHandlers[e].RemoveListener(action);
        _eventHandlers[e].AddListener(action);
    }

    public void UnsubscribeFrom(T e, Action<T, object> action)
    {
        if (!_eventHandlers.ContainsKey(e))
        {
            Debug.Log($"You're trying to unsubscribe from an event {e} that is not handled. Add it to dispatcher first.");
            return;
        }

        _eventHandlers[e].RemoveListener(action);
    }
}
