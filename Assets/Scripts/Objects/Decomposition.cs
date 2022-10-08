using System.Collections.Generic;
using UnityEngine;

public class Decomposition : MonoBehaviour
{
    [SerializeField] private List<Transform> _parts = new();
    [SerializeField] private List<Vector3> _newPosition = new();

    private List<Vector3> _startPosition = new();
    private bool _isDecomposition = false;

    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
            _startPosition.Add(transform.GetChild(i).position);
    }

    public void DecompositionParts()
    {
        if (!_isDecomposition)
        {
            _isDecomposition = true;
            for (int i = 0; i < _parts.Count; i++)
                _parts[i].transform.localPosition = _newPosition[i];
        }
        else
        {
            _isDecomposition = false;
            for (int i = 0; i < _parts.Count; i++)
                _parts[i].transform.localPosition = _startPosition[i];
        }

    }
}
