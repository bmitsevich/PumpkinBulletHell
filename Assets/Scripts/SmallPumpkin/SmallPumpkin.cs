using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallPumpkin : MonoBehaviour
{
    public int starthp;
    int hp;

    // Start is called before the first frame update
    void Start()
    {
        hp = starthp;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            hp -= 1;
            print(hp);
        }

    }
}
