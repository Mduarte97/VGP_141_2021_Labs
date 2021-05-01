using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManger : MonoBehaviour
{
    private Queue<GameObject> objects = new Queue<GameObject>();
    // Start is called before the first frame update

    public Button spawnObject1;
    public Button spawnObject2;
    public Button spawnObject3;

   
    public bool isSpawning;
    public GameObject inventoryMenu;

    ObjectSpawn objectSpawn;
    void Start()
    {
        isSpawning = false;

        if (spawnObject1)
        {
            spawnObject1.onClick.AddListener(() => objects.Enqueue(objectSpawn.object1_Prefab));
        }

        if (spawnObject2)
        {
            spawnObject2.onClick.AddListener(() => objects.Enqueue(objectSpawn.object2_Prefab));
        }

        if (spawnObject3)
        {
            spawnObject3.onClick.AddListener(() => objects.Enqueue(objectSpawn.object3_Prefab));
        }

        objectSpawn = GameObject.FindObjectOfType<ObjectSpawn>();
    }

    IEnumerator QueueTime (GameObject car, float WaitTime )
    {
        isSpawning = true;
        yield return new WaitForSecondsRealtime(WaitTime);
        objects.Dequeue();

        if (car == objectSpawn.object1_Prefab)
        {
            objectSpawn.objectSpawn1();
        }

        else if (car == objectSpawn.object2_Prefab)
        {
            objectSpawn.objectSpawn2();
        }

        else if (car == objectSpawn.object3_Prefab)
        {
            objectSpawn.objectSpawn3();
        }

        isSpawning = false;

    }

    // Update is called once per frame
    private void Update()
    {
        if (objects.Count > 0 && !isSpawning)
        {
            if (objects.Peek() == objectSpawn.object1_Prefab)
            {
                StartCoroutine(QueueTime(objectSpawn.object1_Prefab, 5));
            }

            if (objects.Peek() == objectSpawn.object2_Prefab)
            {
                StartCoroutine(QueueTime(objectSpawn.object2_Prefab, 8));
            }

            if (objects.Peek() == objectSpawn.object3_Prefab)
            {
                StartCoroutine(QueueTime(objectSpawn.object3_Prefab, 10));
            }
        }
    }
}
