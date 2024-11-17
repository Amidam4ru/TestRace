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
        _playerRecorder = FindFirstObjectByType<PlayerRecorder>(); // ����� ������ � ��� ������ ��������
        _playerActions = new List<PlayerAction>(LoadPlayerActionData()); // ������� ������ �������� ������ � ����������� ������
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        int _actionCount = 0;

        while (_actionCount < _playerActions.Count) // ��������� ������� �������� ������ ����
        {
            transform.position = _playerActions[_actionCount].Position;
            transform.rotation = _playerActions[_actionCount].Rotation;

            _actionCount++;
            yield return null;
        }
    }

    private List<PlayerAction> LoadPlayerActionData() // �������� ������� ������ �� ����������
    {
        string json = PlayerPrefs.GetString(PlayerRecorder.RecordedActionsKey, string.Empty);

        if (!string.IsNullOrEmpty(json))
        {
            PlayerActionContainer playerActions = JsonUtility.FromJson<PlayerActionContainer>(json);
            _ghostTime = playerActions.Time; // ����� ���������� ������

            return playerActions.GetPlayerActions();
        }

        return new List<PlayerAction>();
    }
}
