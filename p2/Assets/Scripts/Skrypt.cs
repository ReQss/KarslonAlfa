using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skrypt : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {

            anim.SetInteger("condit",1);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {

            anim.SetInteger("condit", 0);
        }
    }
}
