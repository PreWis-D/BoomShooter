using UnityEngine;
using Zenject;

public class MetaInstaller : MonoInstaller
    {

    [SerializeField] private MetaUIHandler _metaUIHandlerPrefab;

    public override void InstallBindings()
    {
        BindUIHandler();
        BindSceneLoader();
        BindMetaUIBusEvent();
    }

    private void BindUIHandler()
    {
        Container.Bind<MetaUIHandler>().FromComponentInNewPrefab(_metaUIHandlerPrefab).AsSingle();
    }

    private void BindSceneLoader()
    {
        Container.Bind<SceneLoader>().AsSingle();
    }

    private void BindMetaUIBusEvent()
    {
        Container.Bind<MetaUIBusEvent>().AsSingle();
    }
}