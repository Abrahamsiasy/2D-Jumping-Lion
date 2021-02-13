using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{

    public float boxSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerAnimation.instance.playerDied == false){
            StartCoroutine(ObstacleMove());
        }else{
            boxSpeed = 0f;
        }

    }

    //call routine 
    IEnumerator ObstacleMove(){
        yield return new WaitForSeconds(1f);
        transform.Translate(Vector3.left *  Time.deltaTime * boxSpeed);
        //transform.Translate(new Vector3(-1, 0, 0));

    }
}
