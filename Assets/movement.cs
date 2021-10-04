using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private float movementSpeed = 5f;

    public float jumpHeight = 3f;
    public bool isJumping = false;
    public bool grounded = true;
    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
       
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, 0, 0);

        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0 )
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKeyDown("space") && isJumping == false)
        {
            rb2d.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            Debug.Log("jumped");
            isJumping = true;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            isJumping = false;
        }
    }
}

