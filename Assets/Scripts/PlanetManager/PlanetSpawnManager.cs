using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetSpawnManager : SpawnManager
{
   public Planet_Controller _pc;
    public GameObject planet;
    public SphereCollider _panetCol;
    public Camera cam;
    public GameObject SelectedPrefab;
 
    RaycastHit hit;
    private void Start()
    {
        cam = Camera.main;
        _panetCol = planet.GetComponent<SphereCollider>();

    }
    private void Update()
    {
        Debug.DrawRay(cam.transform.position, Vector3.forward, Color.red);
        if (!_pc.rotating)
        {


            if (Input.GetMouseButtonDown(0))
            {
                Spawner();
                
            }
        }
    }

    public Vector3 RandomCircle(Vector3 center,float radius)
    {
        float ang = UnityEngine.Random.value * 360;
        Vector3 pos;
        pos.x=center.x+radius*Mathf.Sin(ang*Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos; 
    }
    public void PlantOnSurface(GameObject prefab)
    {
       _pc.rotating= false; 
        SelectedPrefab = prefab;
        StartCoroutine(CancleRoatation());
    } 
    public void Spawner()
    {
       Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray,out hit,10000))
        {
            if (hit.transform.CompareTag("Planet")&&SelectedPrefab!=null)
            {
                Vector3 _center = planet.transform.position;
                Vector3 pos=RandomCircle(_center,_panetCol.radius);
                Instantiate(SelectedPrefab, hit.point, Quaternion.Euler(-90, 0, 0), transform.parent);
            }
        }
    }
    private void OnDisable()
    {
        StopCoroutine(CancleRoatation());
    }
    IEnumerator CancleRoatation()
    {
        yield return new WaitForSeconds(3);
        _pc.rotating = true;
    }

}
