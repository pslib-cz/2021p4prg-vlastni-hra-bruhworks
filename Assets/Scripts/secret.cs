using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secret : MonoBehaviour
    
{
    public GameObject gameObj;
    public int JumpsNeeded;
    int _jumps = 0;
    private void OnTriggerEnter2D(Collider2D collision)
      {
        if (collision.gameObject.CompareTag("Player"))
        {
            _jumps++;
            if (_jumps == JumpsNeeded)
            {
                Destroy(gameObj);
            }

        }
    }

}
