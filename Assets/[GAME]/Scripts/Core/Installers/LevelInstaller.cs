using UnityEngine;
using Zenject;

public class LevelInstaller : MonoInstaller
{
    [SerializeField] private GameUIHandler _uiHandlerPrefab;

    public override void InstallBindings()
    {
        BindPlayerInput();
        BindUIHandler();
        BindSceneLoader();
        BindLevel();
        BindGameUIBusEvent();
    }

    private void BindPlayerInput()
    {
        Container.Bind<PlayerInput>().AsSingle();
    }

    private void BindUIHandler()
    {
        Container.Bind<GameUIHandler>().FromComponentInNewPrefab(_uiHandlerPrefab).AsSingle();
    }

    private void BindSceneLoader()
    {
        Container.Bind<SceneLoader>().AsSingle();
    }

    private void BindLevel()
    {
        Container.Bind<Level>().AsSingle();
    }

    private void BindGameUIBusEvent()
    {
        Container.Bind<GameUIBusEvent>().AsSingle();
    }
}