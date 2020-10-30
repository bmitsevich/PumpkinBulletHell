using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsBasedBigPumpkinMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    Vector3 movement;

    private void ProcessInputs() {
        movement = new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed, 0.0f);
    }
    void Update()
    {
        ProcessInputs();
        rb.velocity = new Vector2(movement.x, movement.y);
    }
}
