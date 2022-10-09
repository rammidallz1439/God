using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnManager : MonoBehaviour
{



public void Spawner(GameObject obj)
    {
        RaycastHit hit;
        if (Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            Ray touchPos=Camera.main.ScreenPointToRay(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                if (Physics.Raycast(touchPos,out hit))
                {
                    if (hit.transform.CompareTag("Planet"))
                    {
                        Instantiate(obj,touch.position,Quaternion.identity);   
                    }
                }
            }
        }
    }
}
