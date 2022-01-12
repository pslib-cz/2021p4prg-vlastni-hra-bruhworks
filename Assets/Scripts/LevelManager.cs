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

    private void Start()
    {
        Deaths.SetText("Deaths: " + PlayerPrefs.GetInt("deaths"));
    }
    private void Awake()
    {
        instance = this;
    }
    public void Respawn()
    {
        Instantiate(playerPrefab, respointPoint.position, Quaternion.identity);
        int deaths = PlayerPrefs.GetInt("deaths");
        PlayerPrefs.SetInt("deaths", deaths+1);
        Deaths.SetText("Deaths: " + PlayerPrefs.GetInt("deaths"));
    }
}
