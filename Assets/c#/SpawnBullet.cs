using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    public GameObject pfBullet;
    public GameObject pfshoot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(pfshoot, transform.position, transform.rotation);
            Instantiate(pfBullet, transform.position, transform.rotation);
            GetComponent<AudioSource>().Play();
        }
    }
}
