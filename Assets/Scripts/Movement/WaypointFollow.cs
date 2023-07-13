using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollow : MonoBehaviour
{
    private int currentWaypointIndex = 0;
    public float speed = 1.5f;
    private Transform[] waypoints;
    private float distanceThreshold = 0.1f;

    public void SetPathPrefab(Transform pathPrefab)
    {
        Transform[] childWaypoints = pathPrefab.GetComponentsInChildren<Transform>();
        waypoints = new Transform[childWaypoints.Length - 1];

        for (int i = 1; i < childWaypoints.Length; i++)
        {
            waypoints[i - 1] = childWaypoints[i];
        }

        transform.position = waypoints[0].position;
    }

    void Update()
    {
        if (currentWaypointIndex < waypoints.Length)
        {
            Vector3 targetPosition = waypoints[currentWaypointIndex].position;
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            transform.position += moveDirection * speed * Time.deltaTime;

            if (Vector3.Distance(transform.position, targetPosition) <= distanceThreshold)
            {
                currentWaypointIndex++;
            }
        }
    }
}
