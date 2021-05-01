using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public HashTable hashTable;

    [Header("Button")]
    //public Button PlayerInfoButton;
    
   //public Image Menu;

    [Header("Windows")]
    public GameObject DataInputWindow;

    [Header("Inputs")]
    public GameObject InvalidInput;
    public InputField Input;
   
    [Header("Player info")]
    public Text PlayerName;
    public Text PlayerLevel;
    public Text PlayerScore;
    // Start is called before the first frame update


    
 

    public void Start()
    {
      

        if (Input)
        {
            Input.onEndEdit.AddListener((input) => hashTable.PlayerCheck(input));
        }
        



    }

    
}
