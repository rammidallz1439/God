using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PrefabManager : MonoBehaviour, IPrefabInstantiater
{
    public static PrefabManager ins;
    public List<GameObject> ObjectsList;
    
    public GameObject objectToPool;

    GameObject temp;

    [SerializeField]
    int amountToPool;

    public bool canPool;

    #region
    void Start()
    {
        ObjectsList = new List<GameObject>(); //asteroids list
        canPool = false;
        ins = this;
    }


    //function of pooling objects when button is clicked
    public void InstantiatePrefabs()
    {

        canPool = true;
        if (canPool)
        {
            for (int i = 0; i < amountToPool; i++)
            {
                temp = Instantiate(objectToPool);
                temp.SetActive(true);
                ObjectsList.Add(temp);

            }
        }
    }

  

    #endregion
}






