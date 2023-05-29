using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Ctrl : MonoBehaviour
{
    public GameObject pfMonster_A;
    float offsetTime = 3.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > offsetTime)
        {
            Instantiate(pfMonster_A, transform.position, transform.rotation);
            offsetTime = offsetTime + 3.0f;
        }
    }
}