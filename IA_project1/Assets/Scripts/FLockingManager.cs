using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLockingManager : MonoBehaviour
{
    public GameObject beePrefab;
    public int numBees;
    public GameObject[] allBees;


    [Header("Bees Settings")]
    [Range (0.0f, 5.0f)]
    public float minSpeed;
    [Range(0.0f, 5.0f)]
    public float maxSpeed;
    [Range(0.0f, 10.0f)]
    public float neighbourDistance;
    [Range(0.0f, 5.0f)]
    public float rotationSpeed;


    // Start is called before the first frame update
    void Start()
    {
        allBees = new GameObject[numBees];
        for (int i = 0; i < numBees; ++i)
        {
            Vector3 randomize = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));// random vector direction
            Vector3 pos = this.transform.position + randomize; // random position
            allBees[i] = (GameObject)Instantiate(beePrefab, pos, Quaternion.LookRotation(randomize));
            allBees[i].GetComponent<Flock>().myManager = this;
            allBees[i].transform.parent = gameObject.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}
