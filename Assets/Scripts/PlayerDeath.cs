using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerDeath : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Deadly"))
        {
            Destroy(gameObject);
            LevelManager.instance.Respawn();
       
        }
    }
}
