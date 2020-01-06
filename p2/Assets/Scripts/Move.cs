using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float x;
    public float x1;
    public float i;
    public float i1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

        
    {
       
        if (Input.GetKey(KeyCode.LeftArrow)) {

            GetComponent<Rigidbody2D>().velocity = transform.right * -10f;
            transform.localScale = new Vector3(1,1,1);
            i = 0;//
            if (i1 == 0)
            {
                transform.position = transform.position + new Vector3(x1, 0, 0);
            }
       
        


        //
    }
        /*   if (Input.GetKeyUp(KeyCode.LeftArrow))
           {

               GetComponent<Rigidbody2D>().velocity = transform.right * 0f;
           }*/
     
        if (Input.GetKey(KeyCode.RightArrow))
        {
            i1 = 0;
            transform.localScale = new Vector3(-1, 1, 1);
           
            GetComponent<Rigidbody2D>().velocity = transform.right * 10f;
            if (i== 0) {
                    transform.position = transform.position + new Vector3(x, 0, 0); }
            i = 1;
        }

        if ((Input.GetKey(KeyCode.RightArrow)==false)&& (Input.GetKey(KeyCode.LeftArrow)==false))
        {
            GetComponent<Rigidbody2D>().velocity = transform.right * 0f;
        }
      /*  if (Input.GetKey(KeyCode.RightArrow))
        {

            GetComponent<Rigidbody2D>().velocity = transform.right * 0f;
        }*/
    }
}
