using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            TakeDamage(20);
        }
        
    }

    public void TakeDamage(int damage) {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if(currentHealth <= 0) {
             SceneManager.LoadScene("GameOver");
        }
    }

    void OnCollisionStay2D(Collision2D other) {
        if(other.gameObject.tag == "Zombie") {
            TakeDamage(10);
            Debug.Log("ZOMBIE COLLIDED -10 DAMAGE");
        }
    }
}
