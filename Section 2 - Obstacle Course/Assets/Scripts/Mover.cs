using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0f;
    private PlayerInput _controls;
    private Vector2 _moveDir = Vector2.zero;
    
    void Awake() 
    {
        _controls = new PlayerInput();
        _controls.Player.Move.performed += ctx => { _moveDir = ctx.ReadValue<Vector2>(); };
        _controls.Player.Move.canceled += ctx => { _moveDir = ctx.ReadValue<Vector2>(); };
    }

    // Update is called once per frame
    void Update()
    {
        var speedFactor = moveSpeed * Time.deltaTime;
        transform.Translate(_moveDir.x * speedFactor, 0, _moveDir.y * speedFactor);
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }
}
    