using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public TextMeshProUGUI coinsLeft;
    public int cur_coins = 0;
    public int max_coins = 0;

    public GameObject Door;
    public GameObject Key;
    void Start()
    {
        Door.SetActive(false);
        Key.SetActive(false);
        max_coins = cur_coins;
        UpdateUI();

    }

    void Update()
    {
        
    }

    public void UpdateUI(){
        if(cur_coins > 0){
            //this first one would give you 3 digits (D3) for the coins left so for example: Coins Left: 010/030
            //coinsLeft.text = "Coins Left: " + cur_coins.ToString("D3") + "/" + max_coins.ToString("D3");
            coinsLeft.text = "Coins Left: " + cur_coins.ToString() + "/" + max_coins.ToString();
        }
        if(cur_coins < 4){
            Key.SetActive(true);
        }
        if(cur_coins <= 0){
            Door.SetActive(true);
        }
        
    }
}
