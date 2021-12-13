using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float jumpPower = 15f;
    public int extraJumps = 1;
    public LayerMask groundLayer;
    public Rigidbody2D rb;
    public Transform feet;


    bool _isGrounded;
    float _mx;
    float _jumpCoolDown;
    int _jumpCount = 1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(_mx * speed, rb.velocity.y);
    }

    private void Update()
    {
        _mx = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        CheckGrounded();
    }

    void Jump()
    {
        if (_isGrounded || _jumpCount < extraJumps)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            _jumpCount++;
        }
    }

    void CheckGrounded()
    {
        if (Physics2D.OverlapCircle(feet.position, 0.5f, groundLayer))
        {
            _isGrounded = true;
            _jumpCount = 0;
            _jumpCoolDown = Time.time + 0.2f;
        }
        else if (Time.time < _jumpCoolDown)
        {
            _isGrounded = true;
        }
        else
        {
            _isGrounded = false;
        }
    }
}
