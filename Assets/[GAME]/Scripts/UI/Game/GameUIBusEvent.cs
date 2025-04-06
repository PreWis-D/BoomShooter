using UnityEditor;
using UnityEngine;

public class GameUIBusEvent : EventBusBase<UIMetaEvents> { }

public enum UIGameEvents
{
    None = 0,
}