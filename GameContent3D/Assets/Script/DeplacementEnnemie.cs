//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class DeplacementEnnemie : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;

    //Script par Eloge

    public int damageOnCollision = 20;

    private Transform target;
    private int destPoint = 0;

    void Start()
    {
        target = waypoints[0];
    }

    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            destPoint = (destPoint + 1) % waypoints.Length;
            target = waypoints[destPoint];
        }
    }
}
