using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterExplosion_Ctrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject,0.6f);
    }
}
