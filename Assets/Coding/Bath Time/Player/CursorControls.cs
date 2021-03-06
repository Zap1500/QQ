//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Coding/Bath Time/Player/CursorControls.inputactions
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

public partial class @CursorControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CursorControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CursorControls"",
    ""maps"": [
        {
            ""name"": ""BathTime"",
            ""id"": ""145d10d3-1fbf-4b2a-a684-7b2b4e997fd5"",
            ""actions"": [
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""bfac517f-4181-4a32-b23f-d039adf83d88"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""a17b3e89-9a70-4b6b-925b-d51e0368a2d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Position"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ed22fe7a-0430-40da-98f2-b901690ced94"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d425ed4c-2a5f-415d-8902-6343a82ac5a2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0e55e12-c371-4a2b-9af3-afd31fbab5cc"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78405c49-f20e-4300-9e62-b80cb585e06d"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Mini2"",
            ""id"": ""09926a2b-230a-40f1-af6d-88ed25ce42ed"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""f03d0911-8bf2-4465-8f56-74229036d821"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f3f3a396-639c-4721-80f9-9a26fcb2e6e8"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BathTime
        m_BathTime = asset.FindActionMap("BathTime", throwIfNotFound: true);
        m_BathTime_LeftClick = m_BathTime.FindAction("LeftClick", throwIfNotFound: true);
        m_BathTime_RightClick = m_BathTime.FindAction("RightClick", throwIfNotFound: true);
        m_BathTime_Position = m_BathTime.FindAction("Position", throwIfNotFound: true);
        // Mini2
        m_Mini2 = asset.FindActionMap("Mini2", throwIfNotFound: true);
        m_Mini2_Newaction = m_Mini2.FindAction("New action", throwIfNotFound: true);
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

    // BathTime
    private readonly InputActionMap m_BathTime;
    private IBathTimeActions m_BathTimeActionsCallbackInterface;
    private readonly InputAction m_BathTime_LeftClick;
    private readonly InputAction m_BathTime_RightClick;
    private readonly InputAction m_BathTime_Position;
    public struct BathTimeActions
    {
        private @CursorControls m_Wrapper;
        public BathTimeActions(@CursorControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftClick => m_Wrapper.m_BathTime_LeftClick;
        public InputAction @RightClick => m_Wrapper.m_BathTime_RightClick;
        public InputAction @Position => m_Wrapper.m_BathTime_Position;
        public InputActionMap Get() { return m_Wrapper.m_BathTime; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BathTimeActions set) { return set.Get(); }
        public void SetCallbacks(IBathTimeActions instance)
        {
            if (m_Wrapper.m_BathTimeActionsCallbackInterface != null)
            {
                @LeftClick.started -= m_Wrapper.m_BathTimeActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_BathTimeActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_BathTimeActionsCallbackInterface.OnLeftClick;
                @RightClick.started -= m_Wrapper.m_BathTimeActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_BathTimeActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_BathTimeActionsCallbackInterface.OnRightClick;
                @Position.started -= m_Wrapper.m_BathTimeActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_BathTimeActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_BathTimeActionsCallbackInterface.OnPosition;
            }
            m_Wrapper.m_BathTimeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
            }
        }
    }
    public BathTimeActions @BathTime => new BathTimeActions(this);

    // Mini2
    private readonly InputActionMap m_Mini2;
    private IMini2Actions m_Mini2ActionsCallbackInterface;
    private readonly InputAction m_Mini2_Newaction;
    public struct Mini2Actions
    {
        private @CursorControls m_Wrapper;
        public Mini2Actions(@CursorControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Mini2_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Mini2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Mini2Actions set) { return set.Get(); }
        public void SetCallbacks(IMini2Actions instance)
        {
            if (m_Wrapper.m_Mini2ActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_Mini2ActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_Mini2ActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_Mini2ActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_Mini2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public Mini2Actions @Mini2 => new Mini2Actions(this);
    public interface IBathTimeActions
    {
        void OnLeftClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnPosition(InputAction.CallbackContext context);
    }
    public interface IMini2Actions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
