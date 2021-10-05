using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterMovement : MonoBehaviour
{
    float speed = 10f;
    Rigidbody2D monrb2d;
    // Start is called before the first frame update
    void Start()
    {
        monrb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
    }
}
