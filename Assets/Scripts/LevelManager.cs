using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public TextMeshProUGUI Deaths;
    public static LevelManager instance;
    public Transform respointPoint;
    public GameObject playerPrefab;

    int _deaths = 0;

    private void Awake()
    {
        instance = this;
    }
    public void Respawn()
    {
        Instantiate(playerPrefab, respointPoint.position, Quaternion.identity);
        _deaths++;
        Deaths.SetText("Deaths: " + _deaths);
    }
}
