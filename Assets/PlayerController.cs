//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/PlayerController.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerController: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""MovementWASD"",
            ""id"": ""c762834c-f2c8-490b-8eed-f1960fcfae5b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""9525f1f4-b2dd-4810-9fd9-3d827e61bb79"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Drift"",
                    ""type"": ""Button"",
                    ""id"": ""9dc144f1-2f69-4d7e-a0cc-614bc2775908"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""60bf704a-8e1c-4197-8506-1ef0c8f60a1e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""0fb3eff1-c304-4a71-8ac0-134d693138cf"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""1eded2d4-fece-4160-9455-5004b86d344a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""ddeec92d-fc85-4b0a-93b7-5e8c63bbedb7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""f318999c-7d3c-4fbd-9eb3-5ae438d31659"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""28cea720-7e37-4781-a4c6-19f2c6ac4df5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MovementArrows"",
            ""id"": ""2ef5c5ee-0681-479b-816e-bbad7dba23e9"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""1516c59a-ae39-42e0-a570-0ff5ad7acefa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f6ba9bf6-b880-4ea3-9c79-abb0335fff43"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e36da9aa-40d4-4af2-87ed-332e81e331ff"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0fffe301-8c6f-437e-adfd-3dfca8e6a032"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b1329350-f851-41c6-8fe9-9961ccc2bd0c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b90d59c8-56b9-4d62-8677-e11e4158ef0c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""CameraSwitch"",
            ""id"": ""b584cc0f-533f-4cd3-b811-fbe5ed6ae1fc"",
            ""actions"": [
                {
                    ""name"": ""Switch"",
                    ""type"": ""Button"",
                    ""id"": ""cf54b963-c734-4b30-bfe2-c893466c85c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0e41d460-479d-4eb3-8870-29ba0f3037bb"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Switch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // MovementWASD
        m_MovementWASD = asset.FindActionMap("MovementWASD", throwIfNotFound: true);
        m_MovementWASD_Move = m_MovementWASD.FindAction("Move", throwIfNotFound: true);
        m_MovementWASD_Drift = m_MovementWASD.FindAction("Drift", throwIfNotFound: true);
        // MovementArrows
        m_MovementArrows = asset.FindActionMap("MovementArrows", throwIfNotFound: true);
        m_MovementArrows_Move = m_MovementArrows.FindAction("Move", throwIfNotFound: true);
        // CameraSwitch
        m_CameraSwitch = asset.FindActionMap("CameraSwitch", throwIfNotFound: true);
        m_CameraSwitch_Switch = m_CameraSwitch.FindAction("Switch", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // MovementWASD
    private readonly InputActionMap m_MovementWASD;
    private List<IMovementWASDActions> m_MovementWASDActionsCallbackInterfaces = new List<IMovementWASDActions>();
    private readonly InputAction m_MovementWASD_Move;
    private readonly InputAction m_MovementWASD_Drift;
    public struct MovementWASDActions
    {
        private @PlayerController m_Wrapper;
        public MovementWASDActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MovementWASD_Move;
        public InputAction @Drift => m_Wrapper.m_MovementWASD_Drift;
        public InputActionMap Get() { return m_Wrapper.m_MovementWASD; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementWASDActions set) { return set.Get(); }
        public void AddCallbacks(IMovementWASDActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementWASDActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementWASDActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Drift.started += instance.OnDrift;
            @Drift.performed += instance.OnDrift;
            @Drift.canceled += instance.OnDrift;
        }

        private void UnregisterCallbacks(IMovementWASDActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Drift.started -= instance.OnDrift;
            @Drift.performed -= instance.OnDrift;
            @Drift.canceled -= instance.OnDrift;
        }

        public void RemoveCallbacks(IMovementWASDActions instance)
        {
            if (m_Wrapper.m_MovementWASDActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementWASDActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementWASDActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementWASDActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementWASDActions @MovementWASD => new MovementWASDActions(this);

    // MovementArrows
    private readonly InputActionMap m_MovementArrows;
    private List<IMovementArrowsActions> m_MovementArrowsActionsCallbackInterfaces = new List<IMovementArrowsActions>();
    private readonly InputAction m_MovementArrows_Move;
    public struct MovementArrowsActions
    {
        private @PlayerController m_Wrapper;
        public MovementArrowsActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MovementArrows_Move;
        public InputActionMap Get() { return m_Wrapper.m_MovementArrows; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementArrowsActions set) { return set.Get(); }
        public void AddCallbacks(IMovementArrowsActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementArrowsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementArrowsActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IMovementArrowsActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IMovementArrowsActions instance)
        {
            if (m_Wrapper.m_MovementArrowsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementArrowsActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementArrowsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementArrowsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementArrowsActions @MovementArrows => new MovementArrowsActions(this);

    // CameraSwitch
    private readonly InputActionMap m_CameraSwitch;
    private List<ICameraSwitchActions> m_CameraSwitchActionsCallbackInterfaces = new List<ICameraSwitchActions>();
    private readonly InputAction m_CameraSwitch_Switch;
    public struct CameraSwitchActions
    {
        private @PlayerController m_Wrapper;
        public CameraSwitchActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Switch => m_Wrapper.m_CameraSwitch_Switch;
        public InputActionMap Get() { return m_Wrapper.m_CameraSwitch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraSwitchActions set) { return set.Get(); }
        public void AddCallbacks(ICameraSwitchActions instance)
        {
            if (instance == null || m_Wrapper.m_CameraSwitchActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CameraSwitchActionsCallbackInterfaces.Add(instance);
            @Switch.started += instance.OnSwitch;
            @Switch.performed += instance.OnSwitch;
            @Switch.canceled += instance.OnSwitch;
        }

        private void UnregisterCallbacks(ICameraSwitchActions instance)
        {
            @Switch.started -= instance.OnSwitch;
            @Switch.performed -= instance.OnSwitch;
            @Switch.canceled -= instance.OnSwitch;
        }

        public void RemoveCallbacks(ICameraSwitchActions instance)
        {
            if (m_Wrapper.m_CameraSwitchActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICameraSwitchActions instance)
        {
            foreach (var item in m_Wrapper.m_CameraSwitchActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CameraSwitchActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CameraSwitchActions @CameraSwitch => new CameraSwitchActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IMovementWASDActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnDrift(InputAction.CallbackContext context);
    }
    public interface IMovementArrowsActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface ICameraSwitchActions
    {
        void OnSwitch(InputAction.CallbackContext context);
    }
}
