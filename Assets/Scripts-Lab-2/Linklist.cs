using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linklist : MonoBehaviour
{

    LinkedList<string> inventory = new LinkedList<string>();

    public void AddToList(string pItem)
    {
        inventory.AddLast(pItem);
    }

    // Update is called once per frame
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            if (inventory.Count > 0)
            {
                Debug.Log(inventory.First.Value);
                inventory.RemoveFirst();
            }

            else
                inventory.Clear();
        }
       
    }

}
