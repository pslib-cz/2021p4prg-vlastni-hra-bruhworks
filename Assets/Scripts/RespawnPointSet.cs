using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPointSet : MonoBehaviour
{
    Animator an;
    private void Start()
    {
        an = GetComponent<Animator>();
    }
    private void Update()
    {
        if (LevelManager.instance.respointPoint == gameObject.transform)
        {
            an.SetBool("isActive", true);
        }
        else
        {
            an.SetBool("isActive", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            LevelManager.instance.respointPoint = gameObject.transform;
        }
    }

}
