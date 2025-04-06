using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class SettingsPanel : BasePanel
{
    [SerializeField] private Button _backButton;

    private MetaUIBusEvent _busEvent;

    [Inject]
    private void Construct(MetaUIBusEvent busEvent)
    {
        _busEvent = busEvent;
    }

    public override void Init()
    {
        // TODO: implement setting data class

        _backButton.onClick.AddListener(OnStartButtonClicked);
    }

    private void OnStartButtonClicked()
    {
        _busEvent.DispatchEvent(UIMetaEvents.SettingsExitButtonClicked, this);
    }

    private void OnDestroy()
    {
        _backButton.onClick.RemoveListener(OnStartButtonClicked);
    }
}