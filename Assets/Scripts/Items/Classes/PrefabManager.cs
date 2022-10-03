using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabManager : MonoBehaviour, IPrefabInstantiater
{
    public static PrefabManager ins;

    public GameObject meteor;
    public Button _meteorButton;
    public bool canPool;

    #region

    void Awake()
    {
        meteor = GetComponent<GameObject>();
    }
    void Start()
    {
        _meteorButton.onClick.AddListener(InstantiatePrefabs);
         
    }

    public void InstantiatePrefabs() //Interface function Instantiates prefabs
    {
        canPool = true;
        Instantiate(meteor, new Vector3(Random.Range(100, 300), Random.Range(100, 300), Random.Range(100, 300)), Quaternion.identity);


    }



    #endregion
}






