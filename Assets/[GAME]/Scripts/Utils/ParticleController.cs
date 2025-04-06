using System;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class ParticleController : MonoBehaviour
{
    private ParticleSystem[] _particleSystems;

    public void Awake()
    {
        _particleSystems = GetComponentsInChildren<ParticleSystem>();

        var main = _particleSystems[0].main;
        main.stopAction = ParticleSystemStopAction.Callback;
    }

    public void OnEnable()
    {
        _particleSystems[0].Play();
    }

    public void SetColor(Color color)
    {
        for (int i = 0; i < _particleSystems.Length; i++)
        {
            var main = _particleSystems[i].main;
            main.startColor = color;
        }
    }

    internal void Stop()
    {
        _particleSystems[0].Stop();
    }

    private void OnParticleSystemStopped()
    {
        PoolManager.SetPool(this);
    }
}
