using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 4;

    private int _playerIndex = -1;

    private Vector2 inputVector;

    private void Awake()
    {
        inputVector = new Vector2(0, 0);
    }

    private void Update()
    {
        Vector2 inputVector = GetNormalizedDirection();
    }

    private void FixedUpdate()
    {
        Move(inputVector);
    }

    private Vector2 GetNormalizedDirection()
    {
        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y -= 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x += 1;
        }

        inputVector = inputVector.normalized;

        return inputVector;
    }

    private void Move(Vector2 inputVector)
    {
        transform.position += new Vector3(inputVector.x, 0, inputVector.y) * Time.deltaTime * _moveSpeed;
        Debug.Log(inputVector);
    }
}
