using UnityEngine;

[System.Serializable]
public class PlayerAction // Класс хранит позицию и поворот игрока
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private Quaternion _rotation;

    public PlayerAction (Vector3 position, Quaternion rotation)
    {
        _position = position;
        _rotation = rotation;
    }

    public Vector3 Position => _position;
    public Quaternion Rotation => _rotation;
}
