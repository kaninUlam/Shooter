using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beebulletlogic : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D bulletbee = null;
    weapon weapon;
    // Start is called before the first frame update
    void Start()
    {
        bulletbee.velocity = transform.right * speed; // speed of bee projectile
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            Destroy(gameObject);
        }
    }
}
