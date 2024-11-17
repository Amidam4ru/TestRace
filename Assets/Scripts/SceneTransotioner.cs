using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransotioner : MonoBehaviour // класс отвечающий за состояние сцены
{
    [SerializeField] private CheckInСounter _checkInСounter;
    [SerializeField] private CountdownStarting _startingCountdown;
    [SerializeField] private PlayerRecorder _playerRecorder;
    [SerializeField] private PlayerReplayer _playerGhostPrefab;

    private void Start()
    {
        if (_checkInСounter.CheckInCounter > 0)
        {
            PlayerReplayer playerGhost = Instantiate(_playerGhostPrefab); // создаем призрака, если это не первый заезд
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
