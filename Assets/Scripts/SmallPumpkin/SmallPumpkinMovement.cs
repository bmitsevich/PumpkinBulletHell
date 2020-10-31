using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallPumpkinMovement : MonoBehaviour
{
    public Transform rotationCenter;

    public float rotationRadius;
    public float angularSpeed;

    public float posX, posY, angle = 0;


    // Update is called once per frame
    void Update()
    {

        posX = rotationCenter.position.x + Mathf.Cos(angle) * rotationRadius;
        posY = rotationCenter.position.y + Mathf.Sin(angle) * rotationRadius;
        transform.position = new Vector2(posX, posY);

        //if (Input.GetKey("space"))
        if(Input.GetMouseButton(0))
        {
            angle = angle + Time.deltaTime * angularSpeed;
            if (angle >= 360f)
            {
                angle = 0f;
            }
        }
        //if (Input.GetMouseButtonDown(1))
        //{
        //    angularSpeed *= -1;
        //}
        if(Input.GetMouseButton(1))
        {
            angle = angle + Time.deltaTime * -1 * angularSpeed;
            if (angle >= 360f)
            {
                angle = 0f;
            }
        }
    }
}