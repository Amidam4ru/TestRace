using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _firstPersonCamera;
    [SerializeField] private CinemachineVirtualCamera _thirdPersonCamera;
    [SerializeField] private bool _isFirstPerson;

    private PlayerController _playerController; 

    private void Awake()
    {
        _playerController = new PlayerController();;
    }

    private void OnEnable()
    {
        _playerController.CameraSwitch.Enable();
        _playerController.CameraSwitch.Switch.performed += SwitchCamera; 
    }

    private void OnDisable()
    {
        _playerController.CameraSwitch.Switch.performed -= SwitchCamera;
        _playerController.CameraSwitch.Disable();
    }

    private void SwitchCamera(InputAction.CallbackContext context)
    {
        if (!_isFirstPerson) // меняем приоритет
        {
            _firstPersonCamera.Priority = 0;
            _thirdPersonCamera.Priority = 10;
        }
        else
        {
            _firstPersonCamera.Priority = 10;
            _thirdPersonCamera.Priority = 0;
        }

        _isFirstPerson = !_isFirstPerson;
    }
}
