using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigPumpkinMovement : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;
    }
}
