using Zenject;

public class MetaUIHandler : BaseUIHandler
{
    private MetaUIBusEvent _busEvent;
    private SceneLoader _sceneLoader;

    [Inject]
    private void Construct(MetaUIBusEvent metaUIBusEvent, SceneLoader sceneLoader)
    {
        _busEvent = metaUIBusEvent;
        _sceneLoader = sceneLoader;
    }

    public override void Init()
    {
        base.Init();

        GetPanel(PanelType.Lobby).Show();
    }

    protected override void Subscribe()
    {
        _busEvent.SubscribeTo(UIMetaEvents.StartButtonClicked, OnStartButtonClicked);
        _busEvent.SubscribeTo(UIMetaEvents.SettingButtonClicked, OnSettingsButtonClicked);
        _busEvent.SubscribeTo(UIMetaEvents.SettingsExitButtonClicked, OnSettingsExitButtonClicked);
    }

    private void OnStartButtonClicked(UIMetaEvents events, object arg2)
    {
        HideAllPanels();

        GetPanel(PanelType.Load).Show();
        _sceneLoader.LoadScene(SceneType.Game);
    }

    private void OnSettingsButtonClicked(UIMetaEvents events, object arg2)
    {
        HideAllPanels();

        GetPanel(PanelType.Settings).Show();
    }

    private void OnSettingsExitButtonClicked(UIMetaEvents events, object arg2)
    {
        HideAllPanels();

        GetPanel(PanelType.Lobby).Show();
    }

    protected override void Unsubscribe()
    {
        _busEvent.UnsubscribeFrom(UIMetaEvents.StartButtonClicked, OnStartButtonClicked);
        _busEvent.UnsubscribeFrom(UIMetaEvents.SettingButtonClicked, OnSettingsButtonClicked);
        _busEvent.UnsubscribeFrom(UIMetaEvents.SettingsExitButtonClicked, OnSettingsExitButtonClicked);
    }
}