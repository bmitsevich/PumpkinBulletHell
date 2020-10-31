using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BigPumpkin : MonoBehaviour
{
    public int starthp;
    int hp;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        hp = starthp;
        healthBar.SetMaxHealth(hp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Hostile")
        {
            Destroy (collision.gameObject);
            hp -= 1;
            print(hp);
            healthBar.SetHealth(hp);
        }
        if (hp <= 0)
        {
            Destroy(gameObject);
            Cursor.visible = true;
            SceneManager.LoadScene("Game Over");
        }
        
    }
}
