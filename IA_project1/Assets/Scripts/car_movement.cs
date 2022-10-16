using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class car_movement : MonoBehaviour
{
    public GameObject target;
    public NavMeshAgent agent;
    public NavMeshAgent ghost;


    // Update is called once per frame
    void Update()
    {
        Seek();
        /*
        float freq = 0.5f;
        freq += Time.deltaTime;
        if (freq > 0.5)
        {
            freq = 0f;
            Seek();
        }*/
    }


    void Seek()
    {
        agent.destination = target.transform.position;
        if (ghost.isStopped == true)
        {
            agent.isStopped = true;
        }
        else
        {
            agent.isStopped = false;
        }
    }
}
