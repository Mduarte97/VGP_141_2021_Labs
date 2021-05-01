using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashTable : MonoBehaviour
{
    public CanvasManager canvasManager;
    
    

    Hashtable hashTable = new Hashtable();


    // Start is called before the first frame update
    void Start()
    {

        hashTable.Add("Jordan", new PlayerInfo("Jordan", "Level 1", 2000));
        hashTable.Add("Zach", new PlayerInfo("Zach", "Level 2", 2500));
        hashTable.Add("Hayden", new PlayerInfo("Hayden", "Level 3", 1500));
        hashTable.Add("Ola", new PlayerInfo("Ola", "Level 4", 5000));

    }

    // Update is called once per frame
    public void PlayerCheck(string input)
    {
       
            if (hashTable.ContainsKey(input))
            {
                canvasManager.PlayerName.text = ((PlayerInfo)hashTable[input]).Name;
                canvasManager.PlayerLevel.text = ((PlayerInfo)hashTable[input]).Level;
                canvasManager.PlayerScore.text = ((PlayerInfo)hashTable[input]).Score.ToString();
            }
          
        

    }

}
