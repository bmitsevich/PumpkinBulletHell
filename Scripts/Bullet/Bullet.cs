using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector2 velocity;
    public float speed;
    public float rotation;
    public float lifeTime;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0,0,rotation);
        timer = lifeTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity*speed*Time.deltaTime);
        timer-=Time.deltaTime;
        if(timer <= 0)
        {
            Destroy (gameObject);
        }
    }

    public void ResetTimer()
    {
        timer = lifeTime;
    }
}
