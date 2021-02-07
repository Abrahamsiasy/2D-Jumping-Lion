using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    public float groundSpeed = 0.1f;
    private Vector2 offset;
    private new Renderer renderer;

    [HideInInspector]
    public bool groundScroll = false;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (groundScroll){
            offset = new Vector2(Time.time * groundSpeed, 0);
            renderer.material.mainTextureOffset = offset;
        }
    }
}
