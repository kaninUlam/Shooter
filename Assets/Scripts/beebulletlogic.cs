using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beebulletlogic : MonoBehaviour
{
    float speed = 20f;
    public Rigidbody2D bulletbee = null;
    // Start is called before the first frame update
    void Start()
    {
        bulletbee.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            Destroy(this.gameObject);
        }
        
    }
}
