using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int hp;
    public int startHp;
    // Start is called before the first frame update
    void Start()
    {
		hp = startHp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnTriggerEnter2D(Collider2D col)
	{
		switch (col.gameObject.tag)
		{

			case "Player":
			//	MonstersSpawnerControl.spawnAllowed = false;
				//Instantiate (explosion, col.gameObject.transform.position, Quaternion.identity);
				print("sup");
				//Destroy(col.gameObject);
				//target = null;
				break;

			case "Bullet":
				//Instantiate (explosion, transform.position, Quaternion.identity);
				//KillsCounter.killsNumber += 1;
				Destroy(col.gameObject);
				hp -= 1;
				if (hp <= 0)
                {
					Destroy(gameObject);
				}
				
				break;
		}
	}
}
