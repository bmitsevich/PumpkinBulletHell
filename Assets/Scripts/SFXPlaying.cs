using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour
{
    public AudioSource playerShot;
    //public AudioSource enemyShot;
    public AudioSource playerDeath;
    //public AudioSource enemyDeath;

    float timer, cooldown = .3f;
    public void playPlayerShot() {
        playerShot.Play ();
    }
    //public void playEnemyShot() {
    //    enemyShot.Play ();
    //}
    public void playPlayerDeath() {
        playerDeath.Play ();
    }
    //public void playEnemyDeath() {
    //    enemyDeath.Play ();
    //}
    void Update() {
        if(Input.GetKey("space") && timer <= 0) {
            playPlayerShot();
            timer = cooldown;
        }
        timer -= Time.deltaTime;
        if(GameObject.FindGameObjectsWithTag("Player").Length == 1) {
            playPlayerDeath();
        }
    }

}
