using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReplayer : MonoBehaviour
{
    private List<PlayerAction> _playerActions;
    private PlayerRecorder _playerRecorder;
    private float _ghostTime;

    public float GhostTime => _ghostTime;

    private void Start()
    {
        _playerRecorder = FindFirstObjectByType<PlayerRecorder>(); // поиск игрока и его запись действий
        _playerActions = new List<PlayerAction>(LoadPlayerActionData()); // создаем список действий игрока с предыдущего заезда
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        int _actionCount = 0;

        while (_actionCount < _playerActions.Count) // обнавляем позицию призрака каждый кадр
        {
            transform.position = _playerActions[_actionCount].Position;
            transform.rotation = _playerActions[_actionCount].Rotation;

            _actionCount++;
            yield return null;
        }
    }

    private List<PlayerAction> LoadPlayerActionData() // выгрузка позиций игрока из сохранения
    {
        string json = PlayerPrefs.GetString(PlayerRecorder.RecordedActionsKey, string.Empty);

        if (!string.IsNullOrEmpty(json))
        {
            PlayerActionContainer playerActions = JsonUtility.FromJson<PlayerActionContainer>(json);
            _ghostTime = playerActions.Time; // время последнего заезда

            return playerActions.GetPlayerActions();
        }

        return new List<PlayerAction>();
    }
}
