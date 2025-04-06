public class MetaUIBusEvent : EventBusBase<UIMetaEvents> {}

public enum UIMetaEvents
{
    None = 0,
    StartButtonClicked = 1,
    SettingButtonClicked = 2,
    SettingsExitButtonClicked = 3,
}