using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {

    public Transform bigPumpkin, leftWall, rightWall, bottomWall, topWall;
    public float cameraDistance = 30.0f;

    void Awake ()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
    }
    

    void Update ()
    {
        transform.position = new Vector3(Mathf.Clamp(bigPumpkin.position.x, -11, 11),
                                        (Mathf.Clamp(bigPumpkin.position.y, bottomWall.position.y, topWall.position.y)),
                                        (transform.position.z)
                                        );
    }
}