
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabManager : MonoBehaviour, IPrefabInstantiater
{
    public static PrefabManager ins;


   public GameObject[] meteorArray;
   public GameObject[] lifeMeteorArray;

    public Button _meteorButton;
    public Button _lifeMeteorButton;

    #region

    void Start()
    {
        
        _meteorButton.onClick.AddListener(InstantiateMeteor);
       _lifeMeteorButton.onClick.AddListener(InstantiateLifeMeteor);   

    }

 
    public void InstantiateLifeMeteor()
    {
        foreach (GameObject met in lifeMeteorArray)
        {
            Instantiate(met, new Vector3(Random.Range(-300, 300), Random.Range(-300, 300), Random.Range(-300, 300)), Quaternion.identity);
        }
    }

    public void InstantiateMeteor()
    {
        foreach (GameObject met in meteorArray)
        {
            Instantiate(met, new Vector3(Random.Range(-300, 300), Random.Range(-300, 300), Random.Range(-300, 300)), Quaternion.identity);
        }

    }



    #endregion
}








