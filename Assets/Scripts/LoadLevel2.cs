using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//load more levels by going to file build settings and adding a new scene. Every new level is a new scene added to the scenes folder under assets
public class LoadLevel2 : MonoBehaviour
{
    public int levelToLoad2;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "player"){
            Application.LoadLevel(2);
        }
    }
}
