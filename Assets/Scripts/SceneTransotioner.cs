using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransotioner : MonoBehaviour // ����� ���������� �� ��������� �����
{
    [SerializeField] private CheckIn�ounter _checkIn�ounter;
    [SerializeField] private CountdownStarting _startingCountdown;
    [SerializeField] private PlayerRecorder _playerRecorder;
    [SerializeField] private PlayerReplayer _playerGhostPrefab;

    private void Start()
    {
        if (_checkIn�ounter.CheckInCounter > 0)
        {
            PlayerReplayer playerGhost = Instantiate(_playerGhostPrefab); // ������� ��������, ���� ��� �� ������ �����
        }
    }

    private void OnEnable()
    {
        _startingCountdown.Started += FreezeTime;
        _startingCountdown.Finished += UnfreezeTime;
    }

    private void OnDisable()
    {
        _startingCountdown.Started -= FreezeTime;
        _startingCountdown.Finished -= UnfreezeTime;
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void FreezeTime()
    {
        Time.timeScale = 0;
    }

    private void UnfreezeTime()
    {
        Time.timeScale = 1;
    }
}
