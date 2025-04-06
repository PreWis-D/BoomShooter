using System.Collections;
using UnityEngine;

public class DamageViewer : MonoBehaviour
{
    [SerializeField] private MeshRenderer[] _meshRenderers;
    [SerializeField] private SkinnedMeshRenderer[] _skinnedMeshRenderers;
    [SerializeField] private string _shaderColorName;
    [SerializeField] private Color _targetColor;
    [SerializeField] private Color _defaultColor;
    [SerializeField] private float _delayBack = 0.075f;

    public void Blink()
    {
        if (_meshRenderers.Length > 0)
            BlinkMesh();
        if (_skinnedMeshRenderers.Length > 0)
            BlinkSkinnedMesh();
    }

    private void BlinkMesh()
    {
        for (int i = 0; i < _meshRenderers.Length; i++)
        {
            if (_meshRenderers[i].gameObject.activeSelf)
            {
                MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
                _meshRenderers[i].GetPropertyBlock(materialPropertyBlock);
                materialPropertyBlock.SetColor(_shaderColorName, _targetColor);
                _meshRenderers[i].SetPropertyBlock(materialPropertyBlock);
            }
        }

        StartCoroutine(SetDefaultMesh());
    }

    private void BlinkSkinnedMesh()
    {
        for (int i = 0; i < _skinnedMeshRenderers.Length; i++)
        {
            if (_skinnedMeshRenderers[i].gameObject.activeSelf)
            {
                MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
                _skinnedMeshRenderers[i].GetPropertyBlock(materialPropertyBlock);
                materialPropertyBlock.SetColor(_shaderColorName, _targetColor);
                _skinnedMeshRenderers[i].SetPropertyBlock(materialPropertyBlock);
            }
        }

        StartCoroutine(SetDefaultSkinnedMesh());
    }

    private IEnumerator SetDefaultMesh()
    {
        yield return new WaitForSeconds(_delayBack * 1000);

        for (int i = 0; i < _meshRenderers.Length; i++)
        {
            if (_meshRenderers[i].gameObject.activeSelf)
            {
                MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
                _meshRenderers[i].GetPropertyBlock(materialPropertyBlock);
                materialPropertyBlock.SetColor(_shaderColorName, _defaultColor);
                _meshRenderers[i].SetPropertyBlock(materialPropertyBlock);
            }
        }
    }

    private IEnumerator SetDefaultSkinnedMesh()
    {
        yield return new WaitForSeconds(_delayBack * 1000);

        for (int i = 0; i < _skinnedMeshRenderers.Length; i++)
        {
            if (_skinnedMeshRenderers[i].gameObject.activeSelf)
            {
                MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
                _skinnedMeshRenderers[i].GetPropertyBlock(materialPropertyBlock);
                materialPropertyBlock.SetColor(_shaderColorName, _defaultColor);
                _skinnedMeshRenderers[i].SetPropertyBlock(materialPropertyBlock);
            }
        }
    }
}