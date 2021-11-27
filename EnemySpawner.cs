using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // [SerializeField]
    // private float spawnRadius = 7, time = 1.5f;

    // public GameObject[] enemies;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     StartCoroutine(SpawnAnEnemy());
    // }

    // IEnumerator SpawnAnEnemy() {
    //     Vector2 spawnPosition = GameObject.Find("Player").transform.position;
    //     spawnPosition += Random.insideUnitCircle.normalized * spawnRadius;

    //     Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPosition, Quaternion.identity);
    //     yield return new WaitForSeconds(time);
    //     StartCoroutine(SpawnAnEnemy());
    // }

    public GameObject zombie;
    float randX;
    Vector2 spawnLocation;
    public float spawnRate = 1f;
    float nextSpawn = 0.0f;

    void Update() {
        if(Time.time > nextSpawn) {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-8.4f, 8.4f);
            spawnLocation = new Vector2(randX, transform.position.y);
            Instantiate(zombie, spawnLocation, Quaternion.identity);
            FindObjectOfType<AudioManager>().Play("Zombie");
        }
    }
}
