using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRecorder : MonoBehaviour
{
    public const string RecordedActionsKey = "RecordedActions";

    [SerializeField] private CheckIn�ounter _checkIn�ounter;

    private List<PlayerAction> _recordedActions;
    private float _recordedTime;

    public event Action<float> Finished;

    private void Awake()
    {
        _recordedActions = new List<PlayerAction>();
        _recordedTime = 0;
    }

    private void OnEnable()
    {
        _checkIn�ounter.Finished += SaveData;
    }

    private void OnDisable()
    {
        _checkIn�ounter.Finished -= SaveData;
    }

    private void Update()
    {
        RecordAction();
        _recordedTime += Time.deltaTime;
    }

    private void SaveData() // ���������� ���� �������� ������ ��� �������� ������
    {
        PlayerActionContainer actionContainer = new PlayerActionContainer(_recordedActions, _recordedTime);
        Finished?.Invoke(_recordedTime);

        string recordedActionsJson = JsonUtility.ToJson(actionContainer);
        PlayerPrefs.SetString(RecordedActionsKey, recordedActionsJson);
        PlayerPrefs.Save();
    }

    private void RecordAction()
    {
        PlayerAction action = new PlayerAction(transform.position, transform.rotation);

        _recordedActions.Add(action);
    }
}
