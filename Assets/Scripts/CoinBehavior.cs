using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    
    GameManagerScript GMS;
    public float rotateSpeed = 2f;

    void Awake(){
        GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript> ();
        GMS.cur_coins++;
    }


    void Update()
    {
        transform.Rotate(Vector3.left * rotateSpeed);
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "player"){
            Destroy(gameObject);
            GMS.cur_coins--;
            //add score here.. etc
            GMS.UpdateUI();
        }
    }
}
