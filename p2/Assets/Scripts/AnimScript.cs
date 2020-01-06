using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimScript : MonoBehaviour
{
    public float speed = 7;
    private Rigidbody rb;
    CharacterController controller;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimationsAndMovment();
    }

    void AnimationsAndMovment() {


        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetInteger("condition", 1);
            GetComponent<Rigidbody>().velocity = transform.forward * speed;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            anim.SetInteger("condition", 0);
            GetComponent<Rigidbody>().velocity = transform.forward * 0;
            
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody>().velocity = transform.forward * -speed;
            anim.SetInteger("condition", 2);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody>().velocity = transform.forward * 0;
            anim.SetInteger("condition", 0);
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {

            anim.SetInteger("condition", 3);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {

            anim.SetInteger("condition", 0);
        }
    }
   /* private void OnCollisionStay(Collision collision)
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetInteger("condition", 1);
            GetComponent<Rigidbody>().velocity = transform.forward * speed;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            anim.SetInteger("condition", 0);
            GetComponent<Rigidbody>().velocity = transform.forward * 0;

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody>().velocity = transform.forward * -speed;
            anim.SetInteger("condition", 2);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody>().velocity = transform.forward * 0;
            anim.SetInteger("condition", 0);
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {

            anim.SetInteger("condition", 3);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {

            anim.SetInteger("condition", 0);
        }
    }*/
}
