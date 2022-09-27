using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject[] waypoints;
    public int speed = 5;
    private int currentWaypoint = 0;
    float WPradius = 1;

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
            if (currentWaypoint == waypoints.Length)
            {
                Destroy(gameObject);
            }

        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypoint].transform.position, speed * Time.deltaTime);

    }
}