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
    public int level;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Transform feet;
    SpriteRenderer sp;
    Animator an;

    bool _facingRight;
    bool _isGrounded;
    float _mx;
    float _jumpCoolDown;
    int _jumpCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        an = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(_mx * speed, rb.velocity.y);
        if (_mx != 0) _facingRight = (_mx < 0);
        sp.flipX = _facingRight;
    }

    private void Update()
    {
        _mx = Input.GetAxis("Horizontal");
        if(_mx != 0)
        {
            an.SetBool("isMoving", true);
        }
        else
        {
            an.SetBool("isMoving", false);
        }

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
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        level = data.level;
    }
}
