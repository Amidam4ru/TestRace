using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerReader : MonoBehaviour
{
    private PlayerController _playerController;
    private Vector2 _movementInput;
    private float _driftInput;

    public Vector2 MovementInput => _movementInput;
    public float DriftInput => _driftInput;

    private void Awake()
    {
        _playerController = new PlayerController();
    }

    private void OnEnable()
    {
        _playerController.MovementWASD.Enable();
        _playerController.MovementWASD.Move.performed += OnMove;
        _playerController.MovementWASD.Move.canceled += OnMove;

        _playerController.MovementArrows.Enable();
        _playerController.MovementArrows.Move.performed += OnMove;
        _playerController.MovementArrows.Move.canceled += OnMove;

        _playerController.MovementWASD.Drift.performed += OnDrift;
        _playerController.MovementWASD.Drift.canceled += OnDrift;
    }

    private void OnDisable()
    {
        _playerController.MovementWASD.Move.performed -= OnMove;
        _playerController.MovementWASD.Move.canceled -= OnMove;

        _playerController.MovementArrows.Move.performed -= OnMove;
        _playerController.MovementArrows.Move.canceled -= OnMove;

        _playerController.MovementWASD.Drift.performed -= OnDrift;
        _playerController.MovementWASD.Drift.canceled -= OnDrift;

        _playerController.MovementArrows.Disable();
        _playerController.MovementWASD.Disable();
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        _movementInput = new Vector3(context.ReadValue<Vector2>().x, context.ReadValue<Vector2>().y); // —читываем вектор движени€
    }

    private void OnDrift(InputAction.CallbackContext context)
    {
        if (context.performed)  // проверка на дрифт
        {
            _driftInput = 1f;
        }
        else if (context.canceled)
        {
            _driftInput = 0f;
        }
    }
}
