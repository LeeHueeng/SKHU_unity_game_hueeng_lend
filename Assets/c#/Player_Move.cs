using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_Move : MonoBehaviour
{
    float moveLR = 0f;
    public float hPower = 1.0f;
    public bool getKey = false;
    int ud=0;


    Animator playerAni;
    Rigidbody2D playerRigid;
    // Start is called before the first frame update
    void Start()
    {
        playerAni = GetComponent<Animator> ();
        playerRigid = GetComponent<Rigidbody2D> ();
    }
    
    // Update is called once per frame
    void Update()
    {
        moveLR = Input.GetAxisRaw ("Horizontal");
        transform.Translate(transform.right * moveLR * Time.deltaTime * 4.0f);
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerRigid.AddForce(new Vector2 (0, 5.0f), ForceMode2D.Impulse);
            playerAni.SetBool("isJump", true);
        }
        else
        {
            playerAni.SetBool("isJump", false);
            
        }

        if (moveLR == 1 || moveLR == -1)
        {
            playerAni.SetBool("isRun", true);
            if (playerRigid.velocity.y != 0)
            {
                playerAni.SetBool("isRun", false);
                playerAni.SetBool("isJump", true);

            }
        }
        else if (moveLR == 0)
        {
            playerAni.SetBool("isRun", false);
        }
        if (moveLR == 1)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        else if (moveLR == -1)
            {
                transform.rotation = Quaternion.Euler(0, -180, 0);
  
        }

        
        if (ud >= 5){
            SceneManager.LoadScene("noend");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="monster")
        {
            hPower = hPower -0.2f;
            ud=ud+1;
            StartCoroutine(DamageEffect());

         }
        if(other.gameObject.tag=="key")
        {
            Destroy(other.gameObject);
            getKey = true;

         }
    }
    IEnumerator DamageEffect()
    {
        GetComponent<SpriteRenderer>().material.color=Color.red;
        yield return new WaitForSeconds(0.2f);
        GetComponent<SpriteRenderer>().material.color=Color.white;
        yield return new WaitForSeconds(0.2f);

    }
}
