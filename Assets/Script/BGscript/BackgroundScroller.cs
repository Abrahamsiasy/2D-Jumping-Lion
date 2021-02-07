using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BackgroundScroller : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    public float speed = -0.04f;

    [HideInInspector]
    public bool canScroll = false;
    // Start is called before the first frame update
    void Start()
    {
        // get the meshrenderer object from the game
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //get the material property anf the texture offset so it can hel it move
        // use the new vector2 then add the speed to move on x direction by mjltiplying it with delta time 
        if(canScroll)
        {
            meshRenderer.material.mainTextureOffset -= new Vector2(speed * Time.deltaTime, 0);
        }
    }
}
