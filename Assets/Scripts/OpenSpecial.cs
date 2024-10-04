using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSpecial : MonoBehaviour
{
    public GameObject specialDoor;
    void OnTriggerEnter(Collider other){
        if((other.gameObject.tag == "player") && (specialDoor != null)){
            Destroy(specialDoor);
        }
    }
}
