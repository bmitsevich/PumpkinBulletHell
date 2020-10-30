using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimedMonsterShooting : MonoBehaviour {

	GameObject target;
	Vector3 directionToTarget;
    public GameObject bulletResource;
    public float cooldown;
    float timer;
    public float bulletSpeed;

	// Use this for initialization
	void Start () {
		target = GameObject.Find ("smallpumpkin");
		
	}

	// Update is called once per frame
	void Update () {
        Vector3 difference = target.transform.position - transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        print(rotationZ);
		if (timer <= 0)
        {
            
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            print(rotationZ);
            fireBullet(direction, rotationZ);
            timer = cooldown;
        }
        timer -= Time.deltaTime;
	}

    void fireBullet(Vector2 direction, float rotationZ)
    {
        print(rotationZ);
        GameObject b = Instantiate(bulletResource) as GameObject;
        b.transform.position = transform.position;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    }
}
