using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Ball_Move : MonoBehaviour
{
    float speed = 400;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(-transform.right *1000*Time.deltaTime*speed);

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -12)
        {
            Destroy(gameObject);
        }
    }
}
