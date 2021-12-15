using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPSet : MonoBehaviour
{
    public Transform RespawnPoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            LevelManager.instance.respointPoint = RespawnPoint;
        }
    }
}
