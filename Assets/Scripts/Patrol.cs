using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Transform [] patrolPoints;
    public float moveSpeed;
    public float rotationSpeed;
    private int currentPoint;
    // Start is called before the first frame update
    void Start()
    {
        currentPoint = 0;
        transform.position = patrolPoints[currentPoint].position;

    }

    // Update is called once per frame
    void Update()
    {
        // If the character has reached the respected PatrolPoint
        if (transform.position == patrolPoints[currentPoint].position) {
            currentPoint = (currentPoint + 1) % patrolPoints.Length; // point to the nextPosition

          // Rotate the player character in the direction of nextPatrolPoint Position  
            Vector3 dir = patrolPoints[currentPoint].position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(dir);
            Vector3 rotation = Quaternion.Lerp (transform.rotation, lookRotation, 
                        Time.deltaTime * rotationSpeed).eulerAngles;
            transform.rotation = Quaternion.Euler(0f, rotation.y, 0f);
        }

    // Move the chracter to the target Patrol Point direction with desired moveSpeed.
        transform.position = Vector3.MoveTowards(
            transform.position, patrolPoints[currentPoint].position,
            moveSpeed * Time.deltaTime 
        );
    }
}
