using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonstersSpawnerControl : MonoBehaviour {

	public Transform[] spawnPoints;
	public GameObject[] monsters;
	int randomSpawnPoint, randomMonster;
	public static bool spawnAllowed = true;
	public static int wave;
	public static int numMonsters;
	public int curMonsters;
	public float waveTimer = 4f;
	public float timeTillWave = 0.0f;

	public float timeBeforeSpawning = 1.5f;
	public float timeBetweenEnemeis = 1.0f;


	private IEnumerator coroutine;
	private IEnumerator WaitAndPrint(float waitTime)
    {
		yield return new WaitForSeconds(waitTime);
		SpawnAMonster();
    }
	

	// Use this for initialization
	void Start () {
		wave = 1;
		numMonsters = 10;
		curMonsters = 0;
		spawnAllowed = true;
		StartCoroutine(SpawnMonsters());
		//InvokeRepeating("SpawnAMonster", 0f, 1f);
		
	}

     void Update()
    {
		/*
        if (spawnAllowed)
        {
			curMonsters++;
			Invoke("SpawnAMonster", 1.0f);
			//coroutine = WaitAndPrint(3.0f);
			//StartCoroutine(coroutine);
        }

		if (curMonsters > numMonsters)
        {
			spawnAllowed = false;
	
        }
		
		if (!spawnAllowed) //time until next wave
        {
			timeTillWave += Time.deltaTime;
			if (timeTillWave >= waveTimer)
            {
				print("SUP");
				spawnAllowed = true;
				timeTillWave = 0.0f;
				curMonsters = 0;

			}
        }
		*/
		
    }
    void SpawnAMonster()
	{
		
		randomSpawnPoint = Random.Range (0, spawnPoints.Length);
		randomMonster = Random.Range (0, monsters.Length);
		Instantiate (monsters [randomMonster], spawnPoints [randomSpawnPoint].position,
		Quaternion.identity);
		

	}
	
	IEnumerator SpawnMonsters()
    {
		yield return new WaitForSeconds(timeBeforeSpawning);

		while(true)
        {
			if (curMonsters <= 0)
            {
				for (int i = 0; i < numMonsters; i++)
                {
					SpawnAMonster();
					print(curMonsters);
					curMonsters++;
					yield return new WaitForSeconds(timeBetweenEnemeis);
                }
            }
			yield return new WaitForSeconds(5.0f);
			curMonsters = 0;		
        }
    }

}
