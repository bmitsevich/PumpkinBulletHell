using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigPumpkinMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    /*
    void Start()
    {
        
    }
    */
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxis("Vertical")) * speed * Time.deltaTime;
    }
}
