using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    private float movementSpeed = 5f;
    public float jumpHeight = 8f;
    public float horizontalInput = 0f;

    public bool isJumping = false;
    public bool grounded = true;
    public bool FacingRight = false;
    
    Rigidbody2D rb2d;
    
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, 0, 0);

        if (horizontalInput < 0) // when player press a sprite and firepoint rotate to the left
        {
            this.gameObject.transform.eulerAngles = new Vector3(0f, -180f, 0f);

        }
        if (horizontalInput > 0)// when player press a sprite and firepoint rotate to the right
        {
            this.gameObject.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if (Input.GetKeyDown("w") && isJumping == false) // jump script
        {
            rb2d.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            isJumping = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)//to set the player to ground after jumping
    {
        if(collision.gameObject.tag == "ground")
        {
            isJumping = false;
        }
    }
}

