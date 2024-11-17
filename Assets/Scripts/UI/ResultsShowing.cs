using UnityEngine;

public class ResultsShowing : MonoBehaviour
{
    [SerializeField] private ResultPanel _resultPanel;
    [SerializeField] private CheckIn—ounter _checkInCounter;
    [SerializeField] private PlayerRecorder _playerRecorder;
    [SerializeField] private SceneTransotioner _sceneTransotioner;

    private float _playerTime;
    private float _ghostTime;
    private PlayerReplayer _playerReplayer;

    private void Awake()
    {
        _resultPanel.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        _playerRecorder.Finished += Show;
    }

    private void OnDisable()
    {
        _playerRecorder.Finished -= Show;
    }

    private void Show(float playerTime)
    {
        _resultPanel.gameObject.SetActive(true);
        SetPlayerTime(playerTime);
        SetGhostTime();

        _resultPanel.Show(_playerTime, _ghostTime);
    }

    private void SetPlayerTime(float time)
    {
        _playerTime = time;
    }

    private void SetGhostTime()
    {
        _playerReplayer = FindFirstObjectByType<PlayerReplayer>();

        if (_playerReplayer != null)
        {
            _ghostTime = _playerReplayer.GhostTime;
        }
        else
        {
            _ghostTime = 0;
        }
    }
}
