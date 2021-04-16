using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    Linklist Linkedlist;

    public enum Pickups
    {
        BOX,
        SPHERE,
        CYINDER,
    };

    public Pickups currentPickup;
    // Start is called before the first frame update
    void Start()
    {
        
        Linkedlist = GameObject.FindObjectOfType<Linklist>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switch (currentPickup)
            {
                case Pickups.BOX:     
                    Linkedlist.AddToList("box");
                    Destroy(gameObject);
                    break;
                case Pickups.SPHERE:     
                    Linkedlist.AddToList("Sphere");
                    Destroy(gameObject);
                    break;
                case Pickups.CYINDER:            
                   Linkedlist.AddToList("cylinder");
                    Destroy(gameObject);
                    break;
            }
        }
    }
}
