using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bee;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("f"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(bee, firepoint.position, firepoint.rotation);
    }
}
