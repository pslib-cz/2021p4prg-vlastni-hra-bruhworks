using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    //public GameObject impactEffect;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
        EnemyScript enemy = hitInfo.GetComponent<EnemyScript>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        // Instantiate(impactEffect, transform.position, transform.rotation);*/


        if (!hitInfo.gameObject.CompareTag("Player") && !hitInfo.gameObject.CompareTag("Room"))
        {
            Debug.Log(hitInfo.name);
            Destroy(gameObject);
        }
        
    }
}
