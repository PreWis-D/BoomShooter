using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader
{
    private Dictionary<SceneType, string> _scenes = new Dictionary<SceneType, string>()
    {
        { SceneType.Bootstrapp, "0.Bootstrap"},
        { SceneType.Load, "1.Loading"},
        { SceneType.Meta, "2.Meta"},
        { SceneType.Game, "3.Game"},
        { SceneType.Empty, "4.Empty"},
    };

    private CancellationTokenSource _tokenSource;
    private float _fullPercentage = 100f;
    private float _completedPercentage = 90f;

    public event Action<float> ProgressChanged;

    public void LoadScene(SceneType type)
    {
        PoolManager.ClearPool();

        _tokenSource = new CancellationTokenSource();
        Load(_scenes[type], _tokenSource.Token).Forget();
    }

    private async UniTask Load(string sceneName, CancellationToken token)
    {
        float loadingProgress = 0.0f;
        var progressView = loadingProgress * _fullPercentage;

        var asyncOperation = SceneManager.LoadSceneAsync(sceneName);

        while (asyncOperation.isDone == false)
        {
            loadingProgress = Mathf.Clamp01(asyncOperation.progress / (_completedPercentage / _fullPercentage));
            ProgressChanged?.Invoke(loadingProgress);
            await UniTask.Yield();
        }
    }
}

public enum SceneType
{
    Bootstrapp = 0,
    Load = 1,
    Meta = 2,
    Game = 3,
    Empty = 4,
}