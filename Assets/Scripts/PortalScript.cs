using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int _nextLevel;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && !collision.gameObject.CompareTag("Room"))
        {
            GameObject player = collision.gameObject;
            PlayerController playerScript = player.GetComponent<PlayerController>();
            if(playerScript.level <= _nextLevel)
            {
                playerScript.level++;
            }
            
            SaveSystem.SavePlayer(playerScript);
            SceneManager.LoadScene("Level" + _nextLevel);
        }
    }
}
