using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject EnemyPrefab;
    
    [SerializeField]
    private float EnemyInterval = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(EnemyInterval, EnemyPrefab));
    }

    // Update is called once per frame
    private IEnumerator spawnEnemy(float Interval, GameObject Enemy)
    {
        yield return new WaitForSeconds(Interval);
        GameObject newEnemy = Instantiate(EnemyPrefab, transform.position, transform.rotation);
        StartCoroutine(spawnEnemy(Interval, Enemy));
    }
}
