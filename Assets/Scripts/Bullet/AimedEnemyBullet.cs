﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimedEnemyBullet : MonoBehaviour
{
    public float lifeTime;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
       
        timer = lifeTime;
       
    }

    // Update is called once per frame
    void Update()
    {
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
