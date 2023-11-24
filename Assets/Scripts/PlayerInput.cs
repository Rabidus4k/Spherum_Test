using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "PlayerInput", menuName = "Input")]
public class PlayerInput : InputBridge
{
    public InputActionReference inputAction;

    public override Vector2 GetMovement()
    {
        return inputAction.action.ReadValue<Vector2>();
    }
}
