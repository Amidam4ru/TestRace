using TMPro;
using UnityEngine;

public class ResultPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _resultText;
    [SerializeField] private TextMeshProUGUI _playerTimeText;
    [SerializeField] private TextMeshProUGUI _ghostTimeText;
    [SerializeField] private string _winText;
    [SerializeField] private string _loseText;
    [SerializeField] private string _drawText;
    [SerializeField] private string _startPlayerTimeText = "Твой результат: ";
    [SerializeField]  private string _startGhostTimeText = "Результат призрака: ";

    public void Show(float playerTime, float ghostTime)
    {
        // Отображение результата
        if (ghostTime != 0f)
        {
            _playerTimeText.text = _startPlayerTimeText + " " + playerTime;
            _ghostTimeText.text = _startGhostTimeText + " " + ghostTime;

            if (playerTime < ghostTime)
            {
                _resultText.text = _winText;
            }
            else if (playerTime > ghostTime)
            {
                _resultText.text = _loseText;
            }
            else
            {
                _resultText.text = _drawText;
            }
        }
        else
        {
            _resultText.text = " ";
        }
    }
}
