using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollider : MonoBehaviour{

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){
            Debug.Log("Trigger Collsion Detacted");
        }
    }

    void OnTriggerExit(Collider other) {
        Debug.Log("Trigger Collsion Exit Detacted");
    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player"){
            Debug.Log("Collsion Detacted");
        }
    }

    void OnCollisionExit(Collision other) {
        Debug.Log("Collsion Exit Detacted");
    }

}
