using UnityEngine;

public abstract class InputBridge : ScriptableObject
{
    public abstract Vector2 GetMovement();
}