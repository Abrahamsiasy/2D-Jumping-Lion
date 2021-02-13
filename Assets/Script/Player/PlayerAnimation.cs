﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    public static PlayerAnimation instance;
    private Animator animator;
    private Rigidbody2D myRigidbody2D;
    private bool gameStarted;

    private BackgroundScroller BGScroller;
    private GroundScroller groundScroller;
    private BoxSpawner boxSpawner;

    public LayerMask groundLayer;
    public float jump = 10f;
    public Transform groundCheckPos;
    public float radius = 0.5f;

    [HideInInspector]
    public bool isGrounded;

    [SerializeField]
    private BoxCollider2D boxCollider;
    [SerializeField]
    private PolygonCollider2D polygonCollider;

    public GameObject playerDiedEffect;
    [HideInInspector]
    public bool playerDied;



    void Awake() {
        animator = GetComponent<Animator>();
        myRigidbody2D = GetComponent<Rigidbody2D>();
        BGScroller = GameObject.Find("BackgroundPlane").GetComponent<BackgroundScroller>();
        groundScroller = GameObject.Find("Ground").GetComponent<GroundScroller>();
        boxSpawner = GameObject.Find("BoxSpawner").GetComponent<BoxSpawner>();

        Physics2D.IgnoreCollision(boxCollider, polygonCollider, true);
    }
    // Start is called before the first frame update
    void Start()
    {
        MakeInstance();
        StartCoroutine(StartGame());
    }
    void MakeInstance(){
        if (instance == null){
            instance = this;
        }
    }

    void PlayerGrounded(){
        isGrounded = Physics2D.OverlapCircle(groundCheckPos.position, radius, groundLayer);
        Debug.Log(isGrounded+ " isGrounded");
        Debug.Log(gameStarted + " gameStarted");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameStarted && playerDied == false){
            animator.SetFloat("walk", 1f);
            PlayerGrounded();
        }
        PlayerJump(); 
    }

    void PlayerJump(){
        if (Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("space key was pressed");
            if(gameStarted && isGrounded){
                animator.SetBool("jump", true);
                myRigidbody2D.AddForce(new Vector3(0, jump, 0));
            }
        } else {
            animator.SetBool("jump", false);
            //isGrounded = true;

        }
    }
    //call routine 
    IEnumerator StartGame(){
        yield return new WaitForSeconds(3f);
        gameStarted = true;
        BGScroller.canScroll = true;
        groundScroller.groundScroll = true;
        Debug.Log("Background Moving Started");
        
        boxSpawner.canSpawn = true;

    }

    void OnCollisionEnter2D(Collision2D target) {
        if (target.gameObject.tag == "Box"){
            DiedThroughCollison();
        }
    }

    void DiedThroughCollison() {
        Vector3 effectPostion = transform.position;
        Instantiate(playerDiedEffect, effectPostion, Quaternion.identity);//q not rotation
        Destroy(gameObject);//Destroy(target.gameObject);
        playerDied = true;
    }
}
