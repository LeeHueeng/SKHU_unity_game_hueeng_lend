using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

using UnityEngine;
using Random=UnityEngine.Random;


public class monster_Move : MonoBehaviour
{
    public GameObject pfMonExplosion;
    float speed=3.0f;
    int attack=0;
    //float monsterPosX = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime, Space.World);
        if (transform.position.x <= -18.0f)
        {
            speed = speed * -1;
            transform.position = new Vector3(-18.0f, -8f, 0);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (transform.position.x >= 5.0f)
        {
            speed = speed * -1;
            transform.position = new Vector3(5.0f, -8f, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        

        if (attack >= 3)
        {

            Destroy(gameObject);
            Instantiate(pfMonExplosion, transform.position, transform.rotation);
            
        }

        //monsterPosX =  Time.deltaTime * 2f;
        //if (monsterPosX < 0)
        //transform.Translate(monsterPosX, 0, 0);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            
            attack=attack+1;
            Debug.Log(attack);
        }

 

    }
}
