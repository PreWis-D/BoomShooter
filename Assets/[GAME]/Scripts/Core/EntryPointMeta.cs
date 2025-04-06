using UnityEngine;
using Zenject;

public class EntryPointMeta : MonoBehaviour
{
    private MetaUIHandler _uiHandler;

    [Inject]
    private void Construct(MetaUIHandler metaUIHandler)
    {
        _uiHandler = metaUIHandler;
    }

    private void Start()
    {
        _uiHandler.Init();
    }
}
