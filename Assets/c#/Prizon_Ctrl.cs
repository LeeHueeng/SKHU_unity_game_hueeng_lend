using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Prizon_Ctrl : MonoBehaviour
{
    float speed = 3.0f;
    Player_Move player;
    bool isCollision=false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player").GetComponent<Player_Move>();

    }

    // Update is called once per frame
    void Update()
    {
        if (player.getKey==true && isCollision==true)
        {
            transform.Translate(0,speed*Time.deltaTime,0);
            if(transform.position.y>=13)
            {
                transform.position = new Vector3(14,13,0);
                 SceneManager.LoadScene("win");
            }
        }    
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="player")
        {
            isCollision=true;
        }
    }
}
