using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSlow : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject player = collision.gameObject;
            PlayerController playerScript = player.GetComponent<PlayerController>();
            playerScript.speed = 4f;
            playerScript.jumpPower = 8f;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject player = collision.gameObject;
            PlayerController playerScript = player.GetComponent<PlayerController>();
            playerScript.speed = 8f;
            playerScript.jumpPower = 12f;
        }
    }
}
