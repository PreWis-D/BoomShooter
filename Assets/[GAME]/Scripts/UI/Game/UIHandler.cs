using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class UIHandler : MonoBehaviour
{
    //[SerializeField] private BasePanel[] _panels;

    //private Level _level;
    //private GameConfig _gameConfig;
    //private PlayerBalance _playerBalance;
    //private BasePanel _lastPanel;

    //[Inject]
    //private void Construct(Level level, GameConfig gameConfig, PlayerBalance playerBalance)
    //{
    //    _level = level;
    //    _gameConfig = gameConfig;
    //    _playerBalance = playerBalance;
    //}

    //public void Init()
    //{
    //    //_battleUpgradeHandler = battleUpgradeHandler;

    //    var moneyViewPanel = GetPanel<MoneyViewPanel>();
    //    moneyViewPanel.Init(_playerBalance);

    //    var lobbyPanel = GetPanel<LobbyPanel>();
    //    lobbyPanel.Init(_gameConfig.WeaponConfigsPack, _level.Player);

    //    HideAllPanels();

    //    Subscribe();

    //    GetPanel<LobbyPanel>().Show();
    //}

    //public void EnterStartLevel()
    //{
    //    GetPanel<GameLoopPanel>().StartLevel();
    //}

    //public void EnterGameLoop()
    //{
    //    HideAllPanels();

    //    GetPanel<GameLoopPanel>().Show();
    //    GetPanel<MoneyViewPanel>().Show();
    //}

    //public void EnterWaveEnd()
    //{
    //    HideAllPanels();

    //    List<BasePanel> basePanels = new List<BasePanel>();
    //    basePanels.Add(GetPanel<ShopPanel>());
    //    basePanels.Add(GetPanel<MoneyViewPanel>());
    //    StartCoroutine(Delay(basePanels));
    //}

    //public void EnterWin()
    //{
    //    HideAllPanels();

    //    List<BasePanel> basePanels = new List<BasePanel>();
    //    basePanels.Add(GetPanel<WinPanel>());
    //    StartCoroutine(Delay(basePanels));
    //}

    //public void EnterLose()
    //{
    //    HideAllPanels();

    //    List<BasePanel> basePanels = new List<BasePanel>();
    //    basePanels.Add(GetPanel<LosePanel>());
    //    StartCoroutine(Delay(basePanels));
    //}

    //public void EnterPause()
    //{
    //    HideAllPanels();

    //    GetPanel<PausePanel>().Show();
    //}

    //public void EnterUpgrade()
    //{
    //    HideAllPanels();

    //    GetPanel<UpgradePanel>().Show();
    //}

    //public JoystickVirtual GetJoystickVirtual()
    //{
    //    return GetPanel<GameLoopPanel>().JoystickVirtual;
    //}

    //public T GetPanel<T>() where T : BasePanel
    //{
    //    foreach (var panel in _panels)
    //    {
    //        if (panel is T result)
    //            return result;
    //    }

    //    return null;
    //}

    //private void HideAllPanels()
    //{
    //    for (int i = 0; i < _panels.Length; i++)
    //        _panels[i].Hide();
    //}

    //private void OnStartButtonClicked()
    //{
    //    HideAllPanels();

    //    _level.ChangeGameState(GameState.StartLevel);
    //}

    //private void OnNextWaveButtonClicked()
    //{
    //    _level.ChangeGameState(GameState.StartLevel);
    //}

    //private void OnBackLobbyButtonClicked()
    //{
    //    _level.LoadNewLevel();
    //}

    //private void OnSettingsButtonClicked(BasePanel basePanel)
    //{
    //    _lastPanel = basePanel;

    //    HideAllPanels();

    //    GetPanel<SettingsPanel>().Show();
    //}

    //private void OnBackButtonClicked()
    //{
    //    HideAllPanels();

    //    _lastPanel.Show();
    //}

    //private void OnPauseButtonClicked()
    //{
    //    _level.ChangeGameState(GameState.Pause);
    //}

    //private void OnContinueButtonClicked()
    //{
    //    _level.ChangeGameState(GameState.Gameloop);
    //}

    //private void OnPickUpgradeCompleted()
    //{
    //    _level.ChangeGameState(GameState.Gameloop);
    //}

    //private IEnumerator Delay(List<BasePanel> basePanels)
    //{
    //    yield return new WaitForSeconds(2f);

    //    foreach (BasePanel panel in basePanels)
    //        panel.Show();
    //}

    //private void Subscribe()
    //{
    //    var lobbyPanel = GetPanel<LobbyPanel>();
    //    lobbyPanel.StartButtonClicked += OnStartButtonClicked;
    //    lobbyPanel.SettingsButtonClicked += OnSettingsButtonClicked;

    //    var shopPanel = GetPanel<ShopPanel>();
    //    shopPanel.NextWaveButtonClicked += OnNextWaveButtonClicked;

    //    var winPanel = GetPanel<WinPanel>();
    //    winPanel.BackLobbyButtonClicked += OnBackLobbyButtonClicked;

    //    var losePanel = GetPanel<LosePanel>();
    //    losePanel.BackLobbyButtonClicked += OnBackLobbyButtonClicked;

    //    var settingsPanel = GetPanel<SettingsPanel>();
    //    settingsPanel.BackButtonClicked += OnBackButtonClicked;

    //    var gameloopPanel = GetPanel<GameLoopPanel>();
    //    gameloopPanel.PauseButtonClicked += OnPauseButtonClicked;

    //    var pausePanel = GetPanel<PausePanel>();
    //    pausePanel.SettingsButtonClicked += OnSettingsButtonClicked;
    //    pausePanel.ContinueButtonClicked += OnContinueButtonClicked;

    //    var upgradePanel = GetPanel<UpgradePanel>();
    //    upgradePanel.PickUpgradeCompleted += OnPickUpgradeCompleted;
    //}

    //private void Unsubscribe()
    //{
    //    var lobbyPanel = GetPanel<LobbyPanel>();
    //    lobbyPanel.StartButtonClicked -= OnStartButtonClicked;
    //    lobbyPanel.SettingsButtonClicked -= OnSettingsButtonClicked;

    //    var shopPanel = GetPanel<ShopPanel>();
    //    shopPanel.NextWaveButtonClicked -= OnNextWaveButtonClicked;

    //    var winPanel = GetPanel<WinPanel>();
    //    winPanel.BackLobbyButtonClicked -= OnBackLobbyButtonClicked;

    //    var losePanel = GetPanel<LosePanel>();
    //    losePanel.BackLobbyButtonClicked -= OnBackLobbyButtonClicked;

    //    var gameloopPanel = GetPanel<GameLoopPanel>();
    //    gameloopPanel.PauseButtonClicked -= OnPauseButtonClicked;

    //    var pausePanel = GetPanel<PausePanel>();
    //    pausePanel.SettingsButtonClicked += OnSettingsButtonClicked;
    //    pausePanel.ContinueButtonClicked += OnContinueButtonClicked;

    //    var upgradePanel = GetPanel<UpgradePanel>();
    //    upgradePanel.PickUpgradeCompleted -= OnPickUpgradeCompleted;
    //}

    //private void OnDestroy()
    //{
    //    Unsubscribe();
    //}
}