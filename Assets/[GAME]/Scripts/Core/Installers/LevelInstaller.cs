using UnityEngine;
using Zenject;

public class LevelInstaller : MonoInstaller
{
    [SerializeField] private UIHandler _uiHandlerPrefab;

    public override void InstallBindings()
    {
        BindPlayerInput();
        BindUIHandler();
        BindSceneLoader();
        BindLevel();
    }

    private void BindPlayerInput()
    {
        Container.Bind<PlayerInput>().AsSingle();
    }

    private void BindUIHandler()
    {
        Container.Bind<UIHandler>().FromComponentInNewPrefab(_uiHandlerPrefab).AsSingle();
    }

    private void BindSceneLoader()
    {
        Container.Bind<SceneLoader>().AsSingle();
    }

    private void BindLevel()
    {
        Container.Bind<Level>().AsSingle();
    }
}