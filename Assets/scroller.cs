using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class scroller : MonoBehaviour
{
    //Rigidbody2D myRigidBody;
    //Player player = new Player();
    // Start is called before the first frame update


    void LateUpdate() {
        Debug.Log("LateUpdate Called");
    }

    void OnEnable() {
        Debug.Log("OnEnable Called");
    }
    void Start(){
        //myRigidBody = GetComponent<Rigidbody2D>();
        Debug.Log("Starting mETHOD Called");
    }
    void FixedUpdate() {
        Debug.Log("FixedUpdate Called");
    }

    void OnDisable() {
        Debug.Log("OnDisable Method Called");
    }

    void Awake(){
        Debug.Log("Awake Method Called");
    }

    // Update is called once per frame
    void Update(){
        Debug.Log("Update called");
    }
}
