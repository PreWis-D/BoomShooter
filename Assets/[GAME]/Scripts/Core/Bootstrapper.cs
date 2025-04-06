using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    private SceneLoader _loader;

    private void Start()
    {
        _loader = new();    
        StartGame();
    }

    private void StartGame()
    {
        _loader.LoadScene(SceneType.Meta);
    }
}