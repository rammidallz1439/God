using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetSpawnManager : SpawnManager
{

    public GameObject tree;
    public Button _treeButton;

    private void Start()
    {
        _treeButton.onClick.AddListener(SpawnTree);
    }
    public void SpawnTree()
    {
        Spawner(tree); 
    }

}
