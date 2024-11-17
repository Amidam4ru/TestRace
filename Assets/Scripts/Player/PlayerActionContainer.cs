using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerActionContainer //Класс хранения всех действий игрока в предыдущем заезде
{
    [SerializeField] private List<PlayerAction> _actions = new List<PlayerAction>();
    [SerializeField] private float _time;

    public float Time => _time;

    public PlayerActionContainer(List<PlayerAction> playerActions, float time)
    {
        _actions = playerActions;
        _time = time;
    }

    public List<PlayerAction> GetPlayerActions()
    {
        return new List<PlayerAction>(_actions);
    }
}