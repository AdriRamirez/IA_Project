using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traffic_lights : MonoBehaviour
{
    public GameObject redLight;
    public GameObject greenLight;

    void Start()
    {
        StartCoroutine(lightSwitch());
    }

    IEnumerator lightSwitch()
    {
        while (true)
        {
            redLight.SetActive(false);
            greenLight.SetActive(true);
            yield return new WaitForSeconds(10);

            redLight.SetActive(true);
            greenLight.SetActive(false);
            yield return new WaitForSeconds(10);
        }
    }
}
