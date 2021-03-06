//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Programming/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""FPPlayer"",
            ""id"": ""0b34927f-cc2b-4de9-8b25-203c84a93f63"",
            ""actions"": [
                {
                    ""name"": ""Move Forward/Backwards"",
                    ""type"": ""PassThrough"",
                    ""id"": ""64a5d5b0-b38e-41c9-986a-310ce693686b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Move Left/Right"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a6d1ef5b-185f-48f4-9269-27da3685264f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""910954c9-7cae-4429-8fa1-4e43b66bced5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3ea3144a-5a2a-4a72-a50f-d5969353c8ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7b8d37ea-d917-4fb7-ab1d-191a1cb38b98"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a74dc915-415c-4668-85e7-ac5479d6ed8b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aim Down Sights"",
                    ""type"": ""Button"",
                    ""id"": ""bde0b333-1f4b-4192-b1f6-d746caad385d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PauseGame"",
                    ""type"": ""Button"",
                    ""id"": ""ba688af3-eee2-476a-ae2b-ffcf1fe4864c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""InteractWtih "",
                    ""type"": ""Button"",
                    ""id"": ""75575b93-b018-45d2-8613-d6e904b34fdb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""fd9f8615-f07f-42df-8111-1d7adef34605"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""MoveKB"",
                    ""id"": ""10bd47b5-5be8-4171-9ae3-176d142c40aa"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Forward/Backwards"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""a56d87f7-b46b-4f84-a2cf-6172ef4f45d1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Forward/Backwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""64a76770-779c-4b91-a16d-c6817d0ca463"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Forward/Backwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""63b62d1e-a16f-441a-b6b5-217902e903ad"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f295a2f-2b46-4450-8aa8-091c0d1cc783"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim Down Sights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5a5a96f-0352-48ed-9759-d697b39d9a18"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a89b5d4-edce-438b-8744-43f2499a1092"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0dfa4dc9-c85a-4138-a545-64564aaf1ee1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c35607e-f3aa-4407-a3b4-7a9aafecacff"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InteractWtih "",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc756f09-3acd-4768-a651-8485be74f4e3"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""MoveKB"",
                    ""id"": ""5020e220-7be7-451f-ab29-d797efd17054"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Left/Right"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""5cecde15-d9f3-48d6-ac7a-183db61a9fe1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Left/Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""707e68ce-a3d6-40ff-b88c-20f7545e10f0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Left/Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // FPPlayer
        m_FPPlayer = asset.FindActionMap("FPPlayer", throwIfNotFound: true);
        m_FPPlayer_MoveForwardBackwards = m_FPPlayer.FindAction("Move Forward/Backwards", throwIfNotFound: true);
        m_FPPlayer_MoveLeftRight = m_FPPlayer.FindAction("Move Left/Right", throwIfNotFound: true);
        m_FPPlayer_Jump = m_FPPlayer.FindAction("Jump", throwIfNotFound: true);
        m_FPPlayer_Crouch = m_FPPlayer.FindAction("Crouch", throwIfNotFound: true);
        m_FPPlayer_MouseX = m_FPPlayer.FindAction("MouseX", throwIfNotFound: true);
        m_FPPlayer_MouseY = m_FPPlayer.FindAction("MouseY", throwIfNotFound: true);
        m_FPPlayer_AimDownSights = m_FPPlayer.FindAction("Aim Down Sights", throwIfNotFound: true);
        m_FPPlayer_PauseGame = m_FPPlayer.FindAction("PauseGame", throwIfNotFound: true);
        m_FPPlayer_InteractWtih = m_FPPlayer.FindAction("InteractWtih ", throwIfNotFound: true);
        m_FPPlayer_Interact = m_FPPlayer.FindAction("Interact", throwIfNotFound: true);
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

    // FPPlayer
    private readonly InputActionMap m_FPPlayer;
    private IFPPlayerActions m_FPPlayerActionsCallbackInterface;
    private readonly InputAction m_FPPlayer_MoveForwardBackwards;
    private readonly InputAction m_FPPlayer_MoveLeftRight;
    private readonly InputAction m_FPPlayer_Jump;
    private readonly InputAction m_FPPlayer_Crouch;
    private readonly InputAction m_FPPlayer_MouseX;
    private readonly InputAction m_FPPlayer_MouseY;
    private readonly InputAction m_FPPlayer_AimDownSights;
    private readonly InputAction m_FPPlayer_PauseGame;
    private readonly InputAction m_FPPlayer_InteractWtih;
    private readonly InputAction m_FPPlayer_Interact;
    public struct FPPlayerActions
    {
        private @PlayerControls m_Wrapper;
        public FPPlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveForwardBackwards => m_Wrapper.m_FPPlayer_MoveForwardBackwards;
        public InputAction @MoveLeftRight => m_Wrapper.m_FPPlayer_MoveLeftRight;
        public InputAction @Jump => m_Wrapper.m_FPPlayer_Jump;
        public InputAction @Crouch => m_Wrapper.m_FPPlayer_Crouch;
        public InputAction @MouseX => m_Wrapper.m_FPPlayer_MouseX;
        public InputAction @MouseY => m_Wrapper.m_FPPlayer_MouseY;
        public InputAction @AimDownSights => m_Wrapper.m_FPPlayer_AimDownSights;
        public InputAction @PauseGame => m_Wrapper.m_FPPlayer_PauseGame;
        public InputAction @InteractWtih => m_Wrapper.m_FPPlayer_InteractWtih;
        public InputAction @Interact => m_Wrapper.m_FPPlayer_Interact;
        public InputActionMap Get() { return m_Wrapper.m_FPPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FPPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IFPPlayerActions instance)
        {
            if (m_Wrapper.m_FPPlayerActionsCallbackInterface != null)
            {
                @MoveForwardBackwards.started -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnMoveForwardBackwards;
                @MoveForwardBackwards.performed -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnMoveForwardBackwards;
                @MoveForwardBackwards.canceled -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnMoveForwardBackwards;
                @MoveLeftRight.started -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnMoveLeftRight;
                @MoveLeftRight.performed -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnMoveLeftRight;
                @MoveLeftRight.canceled -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnMoveLeftRight;
                @Jump.started -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnCrouch;
                @MouseX.started -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnMouseY;
                @AimDownSights.started -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnAimDownSights;
                @AimDownSights.performed -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnAimDownSights;
                @AimDownSights.canceled -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnAimDownSights;
                @PauseGame.started -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnPauseGame;
                @PauseGame.performed -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnPauseGame;
                @PauseGame.canceled -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnPauseGame;
                @InteractWtih.started -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnInteractWtih;
                @InteractWtih.performed -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnInteractWtih;
                @InteractWtih.canceled -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnInteractWtih;
                @Interact.started -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_FPPlayerActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_FPPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveForwardBackwards.started += instance.OnMoveForwardBackwards;
                @MoveForwardBackwards.performed += instance.OnMoveForwardBackwards;
                @MoveForwardBackwards.canceled += instance.OnMoveForwardBackwards;
                @MoveLeftRight.started += instance.OnMoveLeftRight;
                @MoveLeftRight.performed += instance.OnMoveLeftRight;
                @MoveLeftRight.canceled += instance.OnMoveLeftRight;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
                @AimDownSights.started += instance.OnAimDownSights;
                @AimDownSights.performed += instance.OnAimDownSights;
                @AimDownSights.canceled += instance.OnAimDownSights;
                @PauseGame.started += instance.OnPauseGame;
                @PauseGame.performed += instance.OnPauseGame;
                @PauseGame.canceled += instance.OnPauseGame;
                @InteractWtih.started += instance.OnInteractWtih;
                @InteractWtih.performed += instance.OnInteractWtih;
                @InteractWtih.canceled += instance.OnInteractWtih;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public FPPlayerActions @FPPlayer => new FPPlayerActions(this);
    public interface IFPPlayerActions
    {
        void OnMoveForwardBackwards(InputAction.CallbackContext context);
        void OnMoveLeftRight(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnAimDownSights(InputAction.CallbackContext context);
        void OnPauseGame(InputAction.CallbackContext context);
        void OnInteractWtih(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}
