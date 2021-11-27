using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

     void Start()
    {
        currentHealth = maxHealth;
    }

     public void TakeDamage(int damage) {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if(currentHealth <= 0) {
            Destroy(gameObject);
        }
    }

    void OnCollisionStay2D(Collision2D other) {
        if(other.gameObject.tag == "Bullet") {
            TakeDamage(20);
            Debug.Log("ZOMBIE HIT -20 DAMAGE");
        }
    }

    // [SerializeField] private int attackDamage = 20;
    // public GameObject player; 
    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    // void OnCollisionStay2D(Collision2D other) {
    //     if(other.gameObject.tag == "Player") {
    //         other.gameObject.GetComponent<player.TakeDamage(attackDamage);
    //     }
    // }
}
