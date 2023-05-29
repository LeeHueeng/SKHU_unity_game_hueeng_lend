using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hpgage_Ctrl : MonoBehaviour
{
    Player_Move playerHP;

    void Start()
    {
        playerHP = GameObject.Find("player").GetComponent<Player_Move>();
    }
    void Update()
    {
        GetComponent<Image>().fillAmount = playerHP.hPower;
    }
}
