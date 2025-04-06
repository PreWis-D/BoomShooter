using UnityEngine;
using Zenject;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private CamController _camController;

    private GameConfig _gameConfig;
    private UIHandler _uIHandler;
    private Level _level;
    private PlayerInput _inputActions;

    [Inject]
    private void Consruct(GameConfig gameConfig, UIHandler uIHandler, Level level, PlayerInput inputActions)
    {
        _gameConfig = gameConfig;
        _uIHandler = uIHandler;
        _level = level;
        _inputActions = inputActions;
    }

    private void OnDestroy()
    {
        _inputActions.Disable();
    }
}