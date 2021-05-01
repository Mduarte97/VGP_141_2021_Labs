using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public string Name;
    public string Level;
    public int Score;

    public PlayerInfo (string _name, string _level, int _score)
    {
        Name = _name;
        Level = _level;
        Score = _score;

    }
}
