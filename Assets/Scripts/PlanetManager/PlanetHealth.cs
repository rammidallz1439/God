using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetHealth : MonoBehaviour
{
    public float _health = 100f;
    public Material[] _mats;
    Renderer rend;
    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.sharedMaterial = _mats[0]; 
    }

    private void Update()
    {
        if (_health <= 0f)
        {
            StartCoroutine(ChangeMats());
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Meteor"))
        {
            HealthManager(10f);
        }
    }
    public void HealthManager(float damage)
    {
        _health -= damage;
    }

    IEnumerator ChangeMats()
    {
        yield return new WaitForSeconds(1f);
        rend.sharedMaterial = _mats[1];
    }
}
