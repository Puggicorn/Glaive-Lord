//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/PlayerInput/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player Actions"",
            ""id"": ""e2740ae0-e0df-441a-ba55-e06713ef3d07"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""41e60120-138a-43ea-8ff1-42c6428ff57f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""GlaiveAction1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2cca64e1-7fc8-4d92-aca6-f9a16c2d358f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""19a1c2cd-b0a1-4eb1-b06d-903aa6c714f0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""877645e1-cba5-41a0-be05-2ab7644adba5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8edf9246-4d3b-4105-81be-23dde25a1a54"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""70751e1a-7099-4338-88b0-11f44c9f3a93"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""aa5503b9-e0cb-474c-a5ae-792bb37719fe"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2e9733f4-88be-4aac-8538-6ddb88393e26"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""GlaiveAction1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Debug Actions"",
            ""id"": ""acee32d3-8185-4fe9-81da-485127352fd2"",
            ""actions"": [
                {
                    ""name"": ""Switch"",
                    ""type"": ""Button"",
                    ""id"": ""a8d5ba52-052a-47fc-ba5a-b19f38693c95"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Spawn"",
                    ""type"": ""Button"",
                    ""id"": ""0861a9fb-1468-427c-8f5a-7c2b133f6e66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Test"",
                    ""type"": ""Button"",
                    ""id"": ""475c1d8f-6803-497a-a0d2-e96729327c7d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""902633f3-5fd4-4919-8871-37a3ccf82cbe"",
                    ""path"": ""<Keyboard>/f2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6cbfdc5-2bd2-4169-9348-c0ee71eae4e9"",
                    ""path"": ""<Keyboard>/f3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3f70c1c-bfdf-4235-b7a0-e2288c67948b"",
                    ""path"": ""<Keyboard>/f4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Test"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu Actions"",
            ""id"": ""fceeb8bf-c1d3-4a4d-bffd-e0c71afc9188"",
            ""actions"": [
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""55b82f2e-81d9-43e2-b0a1-3bf8ce26d2da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""70b0017f-ee11-49f3-b72e-d08ba80acc18"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": []
        }
    ]
}");
        // Player Actions
        m_PlayerActions = asset.FindActionMap("Player Actions", throwIfNotFound: true);
        m_PlayerActions_Movement = m_PlayerActions.FindAction("Movement", throwIfNotFound: true);
        m_PlayerActions_GlaiveAction1 = m_PlayerActions.FindAction("GlaiveAction1", throwIfNotFound: true);
        // Debug Actions
        m_DebugActions = asset.FindActionMap("Debug Actions", throwIfNotFound: true);
        m_DebugActions_Switch = m_DebugActions.FindAction("Switch", throwIfNotFound: true);
        m_DebugActions_Spawn = m_DebugActions.FindAction("Spawn", throwIfNotFound: true);
        m_DebugActions_Test = m_DebugActions.FindAction("Test", throwIfNotFound: true);
        // Menu Actions
        m_MenuActions = asset.FindActionMap("Menu Actions", throwIfNotFound: true);
        m_MenuActions_Escape = m_MenuActions.FindAction("Escape", throwIfNotFound: true);
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

    // Player Actions
    private readonly InputActionMap m_PlayerActions;
    private IPlayerActionsActions m_PlayerActionsActionsCallbackInterface;
    private readonly InputAction m_PlayerActions_Movement;
    private readonly InputAction m_PlayerActions_GlaiveAction1;
    public struct PlayerActionsActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActionsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerActions_Movement;
        public InputAction @GlaiveAction1 => m_Wrapper.m_PlayerActions_GlaiveAction1;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMovement;
                @GlaiveAction1.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnGlaiveAction1;
                @GlaiveAction1.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnGlaiveAction1;
                @GlaiveAction1.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnGlaiveAction1;
            }
            m_Wrapper.m_PlayerActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @GlaiveAction1.started += instance.OnGlaiveAction1;
                @GlaiveAction1.performed += instance.OnGlaiveAction1;
                @GlaiveAction1.canceled += instance.OnGlaiveAction1;
            }
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);

    // Debug Actions
    private readonly InputActionMap m_DebugActions;
    private IDebugActionsActions m_DebugActionsActionsCallbackInterface;
    private readonly InputAction m_DebugActions_Switch;
    private readonly InputAction m_DebugActions_Spawn;
    private readonly InputAction m_DebugActions_Test;
    public struct DebugActionsActions
    {
        private @PlayerInputActions m_Wrapper;
        public DebugActionsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Switch => m_Wrapper.m_DebugActions_Switch;
        public InputAction @Spawn => m_Wrapper.m_DebugActions_Spawn;
        public InputAction @Test => m_Wrapper.m_DebugActions_Test;
        public InputActionMap Get() { return m_Wrapper.m_DebugActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugActionsActions set) { return set.Get(); }
        public void SetCallbacks(IDebugActionsActions instance)
        {
            if (m_Wrapper.m_DebugActionsActionsCallbackInterface != null)
            {
                @Switch.started -= m_Wrapper.m_DebugActionsActionsCallbackInterface.OnSwitch;
                @Switch.performed -= m_Wrapper.m_DebugActionsActionsCallbackInterface.OnSwitch;
                @Switch.canceled -= m_Wrapper.m_DebugActionsActionsCallbackInterface.OnSwitch;
                @Spawn.started -= m_Wrapper.m_DebugActionsActionsCallbackInterface.OnSpawn;
                @Spawn.performed -= m_Wrapper.m_DebugActionsActionsCallbackInterface.OnSpawn;
                @Spawn.canceled -= m_Wrapper.m_DebugActionsActionsCallbackInterface.OnSpawn;
                @Test.started -= m_Wrapper.m_DebugActionsActionsCallbackInterface.OnTest;
                @Test.performed -= m_Wrapper.m_DebugActionsActionsCallbackInterface.OnTest;
                @Test.canceled -= m_Wrapper.m_DebugActionsActionsCallbackInterface.OnTest;
            }
            m_Wrapper.m_DebugActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Switch.started += instance.OnSwitch;
                @Switch.performed += instance.OnSwitch;
                @Switch.canceled += instance.OnSwitch;
                @Spawn.started += instance.OnSpawn;
                @Spawn.performed += instance.OnSpawn;
                @Spawn.canceled += instance.OnSpawn;
                @Test.started += instance.OnTest;
                @Test.performed += instance.OnTest;
                @Test.canceled += instance.OnTest;
            }
        }
    }
    public DebugActionsActions @DebugActions => new DebugActionsActions(this);

    // Menu Actions
    private readonly InputActionMap m_MenuActions;
    private IMenuActionsActions m_MenuActionsActionsCallbackInterface;
    private readonly InputAction m_MenuActions_Escape;
    public struct MenuActionsActions
    {
        private @PlayerInputActions m_Wrapper;
        public MenuActionsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Escape => m_Wrapper.m_MenuActions_Escape;
        public InputActionMap Get() { return m_Wrapper.m_MenuActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActionsActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActionsActions instance)
        {
            if (m_Wrapper.m_MenuActionsActionsCallbackInterface != null)
            {
                @Escape.started -= m_Wrapper.m_MenuActionsActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_MenuActionsActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_MenuActionsActionsCallbackInterface.OnEscape;
            }
            m_Wrapper.m_MenuActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
            }
        }
    }
    public MenuActionsActions @MenuActions => new MenuActionsActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    public interface IPlayerActionsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnGlaiveAction1(InputAction.CallbackContext context);
    }
    public interface IDebugActionsActions
    {
        void OnSwitch(InputAction.CallbackContext context);
        void OnSpawn(InputAction.CallbackContext context);
        void OnTest(InputAction.CallbackContext context);
    }
    public interface IMenuActionsActions
    {
        void OnEscape(InputAction.CallbackContext context);
    }
}
