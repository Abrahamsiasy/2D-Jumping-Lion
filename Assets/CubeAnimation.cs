using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;
    private Rigidbody rigidbody;

    public float timer = 2f;
    public float speed = 2f;
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0){
            animator.SetBool("movebool", true);
            animator.SetBool("idlebool", false);

            rigidbody.velocity = new Vector3(-speed, 0, 0);
            timer = 2f;
        }
    }
}
