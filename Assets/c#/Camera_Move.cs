using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{
    Transform player;
    Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        target = new Vector3(player.position.x, player.position.y, player.position.z - 10);
        transform.position = Vector3.Lerp(transform.position, target, 0.01f);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10f, 10f),
            Mathf.Clamp(transform.position.y, -6f, 6f), target.z);

    }
}
