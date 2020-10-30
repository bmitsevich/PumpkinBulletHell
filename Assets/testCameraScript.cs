using UnityEngine;
using System.Collections;

public class testCameraScript : MonoBehaviour {

    public Transform bigPumpkin;
    public float cameraDistance = 30.0f;

    void Awake ()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
    }
    

    void Update ()
    {
        transform.position = new Vector3(bigPumpkin.position.x, bigPumpkin.position.y, transform.position.z);
    }
}