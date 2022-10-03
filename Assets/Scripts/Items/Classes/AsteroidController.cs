using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public GameObject planet;
    float minSpeed = 15f;
    float maxSpped = 50f;

    // Start is called before the first frame update
    void Start()
    {
        planet = GameObject.FindGameObjectWithTag("Planet");

        transform.position = new Vector3(Random.Range(-300, 300), Random.Range(-300, 300), Random.Range(-300, 300));
        transform.localScale = new Vector3(Random.Range(250, 1000), Random.Range(250, 1000), Random.Range(250, 1000));
    }

    private void Update()
    {
        if (PrefabManager.ins.canPool)
        {
            transform.position = Vector3.MoveTowards(transform.position, planet.transform.position, Random.Range(minSpeed, maxSpped) * Time.deltaTime);

        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Planet"))
        {
            Destroy(this.gameObject);

        }
    }


}
