using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public float fireRate = 0.2f;
    public Transform firePoint;
    public GameObject bulletPrefab;

    float _timeUntilFire;
    PlayerController _pc;
    private void Start()
    {
       _pc = gameObject.GetComponent<PlayerController>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && _timeUntilFire < Time.time)
        {
            Shoot();
            _timeUntilFire = Time.time + fireRate;
        }
    }
    void Shoot()
    {
        float angle = _pc.facingRight ? 180f : 0f;
        Instantiate(bulletPrefab, firePoint.position, Quaternion.Euler(new Vector3(0f,0f,angle)));
    }
}
