using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    [SerializeField] private PlayerInput _input;
    [SerializeField] private float _speed = 5;
    private Vector3 _moveVector;

    private void FixedUpdate()
    {
        Vector2 playerInput = _input.GetMovement();
        _moveVector = new Vector3(playerInput.x, transform.position.y, playerInput.y);
        transform.Translate(_moveVector * Time.deltaTime * _speed);
    }
}
