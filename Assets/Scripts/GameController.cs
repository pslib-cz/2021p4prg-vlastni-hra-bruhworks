using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Button[] lvlButtons;
    // Start is called before the first frame update
    void Start()
    {
        int deaths = PlayerPrefs.GetInt("deaths", 0);
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);

        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if(i+2 > levelAt)
            {
                lvlButtons[i].interactable = false;
            }
        }
    }
    public void levelToLoad(int level)
    {
        SceneManager.LoadScene(level+1);
    }
    public void DeleteProgress()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
