using System;
using System.Collections;
using UnityEngine;
using TMPro;

public class CountdownStarting : MonoBehaviour
{
    [SerializeField] private int _numberOfSeconds = 3;
    [SerializeField] private TextMeshProUGUI _countdownText;

    public event Action Started;
    public event Action Finished;

    private void Start()
    {
        Started?.Invoke(); // замораживаем сцену на старте
        StartCoroutine(CountdownCoroutine());
    }

    private IEnumerator CountdownCoroutine() // обратный отсчет на старте
    {
        WaitForSecondsRealtime _waitForSecond = new WaitForSecondsRealtime(1);

        while (_numberOfSeconds > 0)
        {
            _countdownText.text = _numberOfSeconds.ToString();
            _numberOfSeconds--;
            yield return _waitForSecond;
        }

        _countdownText.text = "";
        Finished?.Invoke(); // размораживаем сцену
    }
}
