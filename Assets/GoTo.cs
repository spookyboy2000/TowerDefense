using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoTo : MonoBehaviour
{
    public int damage = 1;
    public Transform[] waypoints;
    private int _currentWaypointIndex = 0;
    public float speed2 = 2f;
    public float speed = 2f;

    private void Update()
    {
        Transform wp = waypoints[_currentWaypointIndex];    // wp = list of waypoints.
        if (Vector3.Distance(transform.position, wp.position) < 0.01f)  // checks distance tussen waypoints.
        {



            _currentWaypointIndex = (_currentWaypointIndex + 1);  // Stuurt je door naar de volgende waypoint in de list.
            
            if (_currentWaypointIndex >= 7)
            {
                
                
            }
        
        }

        else
        {
            // stuurt je naar de eerste waypoint
            transform.position = Vector3.MoveTowards(   
                transform.position,
                wp.position,
                speed2 * Time.deltaTime);
        }

        Vector3 targetDirection = wp.position - transform.position;     // Targets de position of de waypoint.
        float singleStep = speed * Time.deltaTime;      // speed.
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);     // Pakt de rotatie van de waypoint.
        transform.rotation = Quaternion.LookRotation(newDirection);     // laat de object naar de waypoint kijken.

    }

    private void OnTriggerEnter(Collider other)
    {
        UrHealth hp = other.GetComponent<UrHealth>();
        if (hp != null)
        {
            hp.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
