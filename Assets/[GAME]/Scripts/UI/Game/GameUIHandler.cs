using UnityEngine;
using Zenject;

public class GameUIHandler : BaseUIHandler
{
    private GameUIBusEvent _busEvent;
    private SceneLoader _sceneLoader;

    [Inject]
    private void Construct(GameUIBusEvent metaUIBusEvent, SceneLoader sceneLoader)
    {
        _busEvent = metaUIBusEvent;
        _sceneLoader = sceneLoader;
    }

    public override void Init()
    {
        base.Init();
    }

    protected override void Subscribe()
    {
        throw new System.NotImplementedException();
    }

    protected override void Unsubscribe()
    {
        throw new System.NotImplementedException();
    }
}