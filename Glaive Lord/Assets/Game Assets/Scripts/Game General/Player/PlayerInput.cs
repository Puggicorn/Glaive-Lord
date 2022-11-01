using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private Movement playerMovement;
    [SerializeField]
    private PlayerGlaive playerGlaive;

    [SerializeField]
    private PlayerInputActions playerControls;

    [SerializeField]
    private float moveSpeed;

    private InputAction movement;
    private InputAction glaiveAction1;

    private void Awake()
    {
        playerControls = new PlayerInputActions();

        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnEnable()
    {
        movement = playerControls.PlayerActions.Movement;
        movement.Enable();

        glaiveAction1 = playerControls.PlayerActions.GlaiveAction1;
        glaiveAction1.Enable();
        glaiveAction1.performed += GlaiveAction1;
    }

    private void OnDisable()
    {
        movement.Disable();
        glaiveAction1.Disable();
    }

    private void Update()
    {
        Vector2 moveDirection = movement.ReadValue<Vector2>();
        moveDirection.Normalize();
        moveDirection *= moveSpeed;
        playerMovement.moveDirection = moveDirection;

    }

    private void GlaiveAction1(InputAction.CallbackContext context)
    {
        float f = context.ReadValue<float>();
        bool inputFire;

        if(f > 0.5f)
        {
            inputFire = true;
        }
        else
        {
            inputFire = false;
        }
        
        playerGlaive.inputFire = inputFire;
    }


}
