using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;  

public class ContinuousMovement : MonoBehaviour
{
    public float speed = 3.0f;
    private CharacterController characterController;
    private Vector2 inputAxis;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        
        if (Keyboard.current.wKey.isPressed)
        {
            inputAxis = new Vector2(0, 1);  
        }
        else
        {
            inputAxis = Vector2.zero;
        }

        Vector3 moveDirection = new Vector3(inputAxis.x, 0, inputAxis.y);
        moveDirection = transform.TransformDirection(moveDirection) * speed;
        characterController.Move(moveDirection * Time.deltaTime);
    }
}

