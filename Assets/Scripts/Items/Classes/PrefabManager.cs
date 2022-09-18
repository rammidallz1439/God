using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PrefabManager : MonoBehaviour,IPrefabInstantiater
{
    [SerializeField]
    GameObject asteroid;


    public GameObject[] asteroidArray;
    
    public void InstantiatePrefabs()
    {
        
    }
}
