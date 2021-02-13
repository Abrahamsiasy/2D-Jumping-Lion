using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject[] box;
    [HideInInspector]
    public bool canSpawn;

    public float timer;

    public float boxPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canSpawn && PlayerAnimation.instance.playerDied == false){
            if (timer <= 0){
                Spawner();
            }
            timer -= Time.deltaTime;
            }
    }

    void Spawner(){
        int index = Random.Range(0, box.Length);
        Instantiate(box[index], new Vector3(boxPosition, 0, 0), Quaternion.Euler(0, 0, 0));
        timer = 2f;
    }
}
