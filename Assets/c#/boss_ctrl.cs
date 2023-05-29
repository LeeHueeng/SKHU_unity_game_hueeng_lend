using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_ctrl : MonoBehaviour
{
    public GameObject pfBall;
    GameObject child;
    float offsetTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        child = transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        if(Time.time > offsetTime)
        {

            offsetTime += 5.0f;
        }
    }


    // Update is called once per frame
    
    void MakeBall()
    {
        Instantiate(pfBall, child.transform.position, child.transform.rotation);
    }
}