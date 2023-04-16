//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/GameControls.inputactions
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

public partial class @GameControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControls"",
    ""maps"": [
        {
            ""name"": ""Headset"",
            ""id"": ""b4750843-2575-4180-8d15-c8dd68524dab"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""0d1a91c0-10f3-42da-9174-dbe0371f164b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e514ace9-4048-4a77-81f5-389d93bd4721"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""LeftController"",
            ""id"": ""34c93ef8-ce34-48e9-8a74-1f385548e891"",
            ""actions"": [
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""3c26b7a0-178a-4a93-aa77-ed0b71019867"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""77e6d20e-8db5-443c-b6e8-60b348f03236"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TrackingState"",
                    ""type"": ""Value"",
                    ""id"": ""1d8efa48-48bf-4049-85dd-2cc32c0bf9bb"",
                    ""expectedControlType"": ""Integer"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Select Action"",
                    ""type"": ""Button"",
                    ""id"": ""bca5e4ff-4a9f-4b0c-a3cb-1bbcfa808196"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""480ce371-e591-4a9e-8995-3cb629129d57"",
                    ""path"": ""<XRController>{LeftHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb2ab586-6ad2-4c43-b8a7-32e71c252b86"",
                    ""path"": ""<XRController>{LeftHand}/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cac437c-5f05-4132-aff3-618c792b78f9"",
                    ""path"": ""<XRController>{LeftHand}/trackingState"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TrackingState"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71b3b5cb-17bf-437e-81bd-f5f515305aa1"",
                    ""path"": ""<XRController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""RightController"",
            ""id"": ""87b12914-9e9b-4e64-a613-7ad7be3008e3"",
            ""actions"": [
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""b50d1123-92f1-47d6-b8e9-12e0605ad256"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""204b0128-0dfb-4908-8063-eb357d4c80fd"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TrackingState"",
                    ""type"": ""Value"",
                    ""id"": ""7f12211a-23cf-4f02-ae1a-785f0fc3ffac"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Select Action"",
                    ""type"": ""Button"",
                    ""id"": ""9bd7d8c1-f1b2-44dd-b8c3-d516ff00500c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Haptics"",
                    ""type"": ""Value"",
                    ""id"": ""205d49a8-447a-4de1-908d-59e2e9400b77"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7a9e390b-1e0e-4862-912a-2fa2b9a46844"",
                    ""path"": ""<XRController>{RightHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""89dae56d-e562-4f2a-afb5-1c3e3b1b155e"",
                    ""path"": ""<XRController>{RightHand}/trackingState"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TrackingState"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""715cb226-c34d-4519-af97-7c4bbd811146"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6521381-1f40-4f12-b10e-57e9d5f1e5ed"",
                    ""path"": ""<XRController>{RightHand}/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77eedcdf-741f-416c-8366-483648b67cd6"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Haptics"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Headset
        m_Headset = asset.FindActionMap("Headset", throwIfNotFound: true);
        m_Headset_Newaction = m_Headset.FindAction("New action", throwIfNotFound: true);
        // LeftController
        m_LeftController = asset.FindActionMap("LeftController", throwIfNotFound: true);
        m_LeftController_Position = m_LeftController.FindAction("Position", throwIfNotFound: true);
        m_LeftController_Rotation = m_LeftController.FindAction("Rotation", throwIfNotFound: true);
        m_LeftController_TrackingState = m_LeftController.FindAction("TrackingState", throwIfNotFound: true);
        m_LeftController_SelectAction = m_LeftController.FindAction("Select Action", throwIfNotFound: true);
        // RightController
        m_RightController = asset.FindActionMap("RightController", throwIfNotFound: true);
        m_RightController_Position = m_RightController.FindAction("Position", throwIfNotFound: true);
        m_RightController_Rotation = m_RightController.FindAction("Rotation", throwIfNotFound: true);
        m_RightController_TrackingState = m_RightController.FindAction("TrackingState", throwIfNotFound: true);
        m_RightController_SelectAction = m_RightController.FindAction("Select Action", throwIfNotFound: true);
        m_RightController_Haptics = m_RightController.FindAction("Haptics", throwIfNotFound: true);
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

    // Headset
    private readonly InputActionMap m_Headset;
    private IHeadsetActions m_HeadsetActionsCallbackInterface;
    private readonly InputAction m_Headset_Newaction;
    public struct HeadsetActions
    {
        private @GameControls m_Wrapper;
        public HeadsetActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Headset_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Headset; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HeadsetActions set) { return set.Get(); }
        public void SetCallbacks(IHeadsetActions instance)
        {
            if (m_Wrapper.m_HeadsetActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_HeadsetActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_HeadsetActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_HeadsetActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_HeadsetActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public HeadsetActions @Headset => new HeadsetActions(this);

    // LeftController
    private readonly InputActionMap m_LeftController;
    private ILeftControllerActions m_LeftControllerActionsCallbackInterface;
    private readonly InputAction m_LeftController_Position;
    private readonly InputAction m_LeftController_Rotation;
    private readonly InputAction m_LeftController_TrackingState;
    private readonly InputAction m_LeftController_SelectAction;
    public struct LeftControllerActions
    {
        private @GameControls m_Wrapper;
        public LeftControllerActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Position => m_Wrapper.m_LeftController_Position;
        public InputAction @Rotation => m_Wrapper.m_LeftController_Rotation;
        public InputAction @TrackingState => m_Wrapper.m_LeftController_TrackingState;
        public InputAction @SelectAction => m_Wrapper.m_LeftController_SelectAction;
        public InputActionMap Get() { return m_Wrapper.m_LeftController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeftControllerActions set) { return set.Get(); }
        public void SetCallbacks(ILeftControllerActions instance)
        {
            if (m_Wrapper.m_LeftControllerActionsCallbackInterface != null)
            {
                @Position.started -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnPosition;
                @Rotation.started -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnRotation;
                @TrackingState.started -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnTrackingState;
                @TrackingState.performed -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnTrackingState;
                @TrackingState.canceled -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnTrackingState;
                @SelectAction.started -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnSelectAction;
                @SelectAction.performed -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnSelectAction;
                @SelectAction.canceled -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnSelectAction;
            }
            m_Wrapper.m_LeftControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @TrackingState.started += instance.OnTrackingState;
                @TrackingState.performed += instance.OnTrackingState;
                @TrackingState.canceled += instance.OnTrackingState;
                @SelectAction.started += instance.OnSelectAction;
                @SelectAction.performed += instance.OnSelectAction;
                @SelectAction.canceled += instance.OnSelectAction;
            }
        }
    }
    public LeftControllerActions @LeftController => new LeftControllerActions(this);

    // RightController
    private readonly InputActionMap m_RightController;
    private IRightControllerActions m_RightControllerActionsCallbackInterface;
    private readonly InputAction m_RightController_Position;
    private readonly InputAction m_RightController_Rotation;
    private readonly InputAction m_RightController_TrackingState;
    private readonly InputAction m_RightController_SelectAction;
    private readonly InputAction m_RightController_Haptics;
    public struct RightControllerActions
    {
        private @GameControls m_Wrapper;
        public RightControllerActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Position => m_Wrapper.m_RightController_Position;
        public InputAction @Rotation => m_Wrapper.m_RightController_Rotation;
        public InputAction @TrackingState => m_Wrapper.m_RightController_TrackingState;
        public InputAction @SelectAction => m_Wrapper.m_RightController_SelectAction;
        public InputAction @Haptics => m_Wrapper.m_RightController_Haptics;
        public InputActionMap Get() { return m_Wrapper.m_RightController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RightControllerActions set) { return set.Get(); }
        public void SetCallbacks(IRightControllerActions instance)
        {
            if (m_Wrapper.m_RightControllerActionsCallbackInterface != null)
            {
                @Position.started -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnPosition;
                @Rotation.started -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnRotation;
                @TrackingState.started -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnTrackingState;
                @TrackingState.performed -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnTrackingState;
                @TrackingState.canceled -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnTrackingState;
                @SelectAction.started -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnSelectAction;
                @SelectAction.performed -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnSelectAction;
                @SelectAction.canceled -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnSelectAction;
                @Haptics.started -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnHaptics;
                @Haptics.performed -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnHaptics;
                @Haptics.canceled -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnHaptics;
            }
            m_Wrapper.m_RightControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @TrackingState.started += instance.OnTrackingState;
                @TrackingState.performed += instance.OnTrackingState;
                @TrackingState.canceled += instance.OnTrackingState;
                @SelectAction.started += instance.OnSelectAction;
                @SelectAction.performed += instance.OnSelectAction;
                @SelectAction.canceled += instance.OnSelectAction;
                @Haptics.started += instance.OnHaptics;
                @Haptics.performed += instance.OnHaptics;
                @Haptics.canceled += instance.OnHaptics;
            }
        }
    }
    public RightControllerActions @RightController => new RightControllerActions(this);
    public interface IHeadsetActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface ILeftControllerActions
    {
        void OnPosition(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnTrackingState(InputAction.CallbackContext context);
        void OnSelectAction(InputAction.CallbackContext context);
    }
    public interface IRightControllerActions
    {
        void OnPosition(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnTrackingState(InputAction.CallbackContext context);
        void OnSelectAction(InputAction.CallbackContext context);
        void OnHaptics(InputAction.CallbackContext context);
    }
}
