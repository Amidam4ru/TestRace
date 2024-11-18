using UnityEngine;
using TMPro;
using System;

[RequireComponent(typeof(Collider))]
public class CheckInСounter : MonoBehaviour
{
    private const string CheckInKey = "CheckInNumber";

    [SerializeField] private TextMeshProUGUI _checkInText;
    [SerializeField] private CheckpointsTracker _checkpointsTracker;

    private int _checkInCounter;
    private bool _isStart;
    private string _startText;

    public event Action Finished;

    public int CheckInCounter => _checkInCounter;

    private void Awake()
    {
        _isStart = false;
        _checkInCounter = GetCheckInCounter();
    }

    private void Start()
    {
        _startText = _checkInText.text;
        _checkInText.text = _checkInCounter.ToString() + " " + _startText;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.TryGetComponent(out PlayerRecorder playerRecorder))
        {
            if (_isStart == false)
            {
                _isStart = true;
            }
            else
            {
                if (_checkpointsTracker.IsCpllected)  //проверка прохождения всех чекпоинтов
                {
                    _checkInCounter++;
                    SaveCheckInCounter();
                    Finished?.Invoke(); //объявляем финиш
                }
            }  
        }
    }

    private void SaveCheckInCounter() // Сохранение количества заездов
    {
        PlayerPrefs.SetInt(CheckInKey, _checkInCounter);
        PlayerPrefs.Save();
    }

    private int GetCheckInCounter()
    {
        return PlayerPrefs.GetInt(CheckInKey, 1);
    }
}
