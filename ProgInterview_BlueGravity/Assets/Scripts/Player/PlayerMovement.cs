using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float MoveSpeed;

    private float horizontalMove = 0f;
    private float verticalMove = 0f;

    void Update() {
        horizontalMove = Input.GetAxisRaw("Horizontal") * MoveSpeed;
        verticalMove = Input.GetAxisRaw("Vertical") * MoveSpeed;
    }
}
