using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {

    public Transform bigPumpkin, minVertWall, maxVertWall, minHorizWall, maxHorizWall;
    public float cameraDistance = 30.0f;

    void Awake ()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
    }
    

    void Update ()
    {
        transform.position = new Vector3(Mathf.Clamp(bigPumpkin.position.x, minHorizWall.position.x, maxHorizWall.position.x),
                                        (Mathf.Clamp(bigPumpkin.position.y, minVertWall.position.y, maxVertWall.position.y)),
                                        (transform.position.z)
                                        );
    }
}