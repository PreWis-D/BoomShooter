using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class LoadPanel : BasePanel
{
    [SerializeField] private TMP_Text _loadingPercentText;
    [SerializeField] private Slider _progressBar;

    private SceneLoader _sceneLoader;
    private float _fullPercentage = 100f;

    [Inject]
    private void Construct(SceneLoader sceneLoader)
    {
        _sceneLoader = sceneLoader;
    }

    public override void Init()
    {
        _sceneLoader.ProgressChanged += OnProgressChanged;
    }

    private void OnProgressChanged(float value)
    {
        var loadingProgressView = value * _fullPercentage;
        _loadingPercentText.SetText($"{loadingProgressView}%");
        _progressBar.value = value;
    }

    public void OnDestroy()
    {
        _sceneLoader.ProgressChanged -= OnProgressChanged;
    }
}