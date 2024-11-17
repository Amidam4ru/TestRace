using System.Collections.Generic;
using UnityEngine;

public class CheckpointsTracker : MonoBehaviour
{
    [SerializeField] private List<Checkpoint> _checkPoints;

    private bool _isCpllected;

    public bool IsCpllected => _isCpllected;

    private void Start()
    {
        _isCpllected = false;
    }

    private void OnEnable()
    {
        foreach (Checkpoint checkpoint in _checkPoints)
        {
            checkpoint.PlayerChecked += RemoveCheckpoint;
        }
    }

    private void OnDisable()
    {
        foreach (Checkpoint checkpoint in _checkPoints)
        {
            checkpoint.PlayerChecked -= RemoveCheckpoint;
        }
    }

    private void RemoveCheckpoint(Checkpoint checkpoint)
    {
        if (_checkPoints.Contains(checkpoint))
        {
            _checkPoints.Remove(checkpoint); // удаляем чекпоинт, через который прошел игрок

            if (_checkPoints.Count == 0)
            {
                _isCpllected = true;
            }
        }
    }
}
