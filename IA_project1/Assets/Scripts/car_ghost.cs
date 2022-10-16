using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class car_ghost : MonoBehaviour
{

    public GameObject[] waypoints;
    int patrolWP = 0;
    public traffic_lights tl;

    private NavMeshAgent agent;


    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            Patrol();

        if (tl.greenLight.active == true)
        {
            agent.isStopped = false;
            //agent.autoBraking = false;
        }
    }

    void Patrol()
    {
        if (waypoints.Length == 0)
            return;

        agent.destination = waypoints[patrolWP].transform.position;
        patrolWP = (patrolWP + 1) % waypoints.Length;



    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("tlc") && tl.redLight.active == true)
        {
            agent.isStopped = true;
            agent.autoBraking = true;

        }

    }
}
