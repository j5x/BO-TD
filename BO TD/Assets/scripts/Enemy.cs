using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class Enemy : MonoBehaviour
{ 
    public GameObject[] waypoints;
    public int Health;
    public int speed;
    private int currentWaypoint = 0;
    float WPradius = .1f;
    private Shop shopscript;
    WaveSpawner waveSpawner;

    public void Start()
    {
        shopscript = FindObjectOfType<Shop>();
    }


    void Update()
    {
        if (Vector3.Distance(waypoints[currentWaypoint].transform.position, transform.position) < WPradius)
        {
            if (currentWaypoint + 1 > waypoints.Length)
            {
                currentWaypoint = 0;
            }
            else
            {
                currentWaypoint++;
            }
            if (currentWaypoint == waypoints.Length - 1)
            {
                Destroy(gameObject);
            }
            if (currentWaypoint == 8)
            {
                Application.LoadLevel(0);
            }
            
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypoint].transform.position, speed * Time.deltaTime);

    }



    public void TakeDamage()
    {
        
        if (Health == 0)
        {
           shopscript.currency++;
           Destroy(gameObject);
            
        }
    }
}