using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secret : MonoBehaviour
    
{
    public GameObject gameObj;
    public int JumpsNeeded;
    int _jumps = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Secret"))
        {
            _jumps++;
            if (_jumps == JumpsNeeded) { }

        }
    }

}
