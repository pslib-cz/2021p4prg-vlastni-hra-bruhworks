using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    // Start is called before the first frame update
    public int level;

    public PlayerData(PlayerController player)
    {
        level = PlayerPrefs.GetInt("levelAt");
    }
}
