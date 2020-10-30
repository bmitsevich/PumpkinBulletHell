using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {

    public Transform bigPumpkin;
    public float smoothing;
    public Vector2 minPosition, maxPosition;

    void Start ()
    {
        
    }
    
    void LateUpdate ()
    {
        //transform.position = new Vector3(bigPumpkin.transform.position.x, bigPumpkin.transform.position.y, -10.0f);
        if(transform.position != bigPumpkin.position)
        {
            Vector3 bigPumpkinPosition = new Vector3(bigPumpkin.position.x, bigPumpkin.position.y, transform.position.z);

            bigPumpkinPosition.x = Mathf.Clamp(bigPumpkinPosition.x, minPosition.x, maxPosition.x);
            bigPumpkinPosition.y = Mathf.Clamp(bigPumpkinPosition.y, minPosition.y, maxPosition.y);

            transform.position = Vector3.Lerp(transform.position, bigPumpkinPosition, smoothing);
        }
    }
}