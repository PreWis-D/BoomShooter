using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class LobbyPanel : BasePanel
{
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _settingsButton;

    private MetaUIBusEvent _busEvent;

    [Inject]
    private void Construct(MetaUIBusEvent busEvent)
    {
        _busEvent = busEvent;
    }

    public override void Init()
    {
        _startButton.onClick.AddListener(OnStartButtonClicked);
        _settingsButton.onClick.AddListener(OnSettingsButtonClicked);
    }

    private void OnStartButtonClicked()
    {
        _busEvent.DispatchEvent(UIMetaEvents.StartButtonClicked, this);
    }

    private void OnSettingsButtonClicked()
    {
        _busEvent.DispatchEvent(UIMetaEvents.SettingButtonClicked, this);
    }

    private void OnDestroy()
    {
        _settingsButton.onClick.RemoveListener(OnSettingsButtonClicked);
        _startButton.onClick.RemoveListener(OnStartButtonClicked);
    }
}