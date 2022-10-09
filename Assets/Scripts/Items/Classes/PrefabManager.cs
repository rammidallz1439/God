using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabManager : MonoBehaviour, IPrefabInstantiater
{
    public static PrefabManager ins;

    [Header("Meteor")]
    public GameObject meteor;
    public Transform SpawnPosMeteor;




    public Button _meteorButton;
    public bool canPool;

    #region

    void Start()
    {
        
        _meteorButton.onClick.AddListener(InstantiatePrefabs);
         
    }

    public void InstantiatePrefabs() //Interface function Instantiates prefabs
    {
        Instantiate(meteor, SpawnPosMeteor.position, Quaternion.identity);


    }



    #endregion
}






