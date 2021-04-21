using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    public GameObject object1_Prefab;
    public GameObject object2_Prefab;
    public GameObject object3_Prefab;

    public Transform spawnLocation1;
    public Transform spawnLocation2;
    public Transform spawnLocation3;

    public void objectSpawn1()
    {
        Instantiate(object1_Prefab, spawnLocation1.position, spawnLocation1.rotation);
    }

    public void objectSpawn2()
    {
        Instantiate(object2_Prefab, spawnLocation2.position, spawnLocation2.rotation);
    }

    public void objectSpawn3()
    {
        Instantiate(object3_Prefab, spawnLocation3.position, spawnLocation3.rotation);
    }
}
