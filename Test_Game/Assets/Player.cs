using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    PlayerInput playerInput;
    const float SPEED = 10;

    private void Awake()
    {
        playerInput = new PlayerInput();
        playerInput.Player.Enable();
    }

    //Update is called once per frame
    void Update()
    {
        Vector2 inputVector = playerInput.Player.Move.ReadValue<Vector2>().normalized;
        Vector3 moveDir = new Vector3(inputVector.x, 0, inputVector.y);

        transform.position += moveDir * SPEED * Time.deltaTime;
    }
}