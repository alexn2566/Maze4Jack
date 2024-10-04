using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//load more levels by going to file build settings and adding a new scene. Every new level is a new scene added to the scenes folder under assets
public class LoadLevel : MonoBehaviour
{
    public int levelToLoad;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "player"){
            Application.LoadLevel(1);
        }
    }
}
