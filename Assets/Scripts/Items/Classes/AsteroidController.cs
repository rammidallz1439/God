using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    private GameObject planet;
    float maxSpped = 50f;

    void Start()
    {
        planet = GameObject.FindGameObjectWithTag("Planet");

    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, planet.transform.position, maxSpped * Time.deltaTime);


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Planet"))
        {
            Destroy(this.gameObject);

        }
    }


}
