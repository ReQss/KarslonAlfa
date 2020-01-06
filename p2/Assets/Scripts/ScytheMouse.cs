using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScytheMouse : MonoBehaviour
{
    private Rigidbody2D rb;
    float x;
    float y;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
     
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Mouse X");
        y = Input.GetAxis("Mouse Y");
        if (Input.GetKey(KeyCode.Mouse0))
        {
            rb.transform.position = transform.position + new Vector3(x, y * 0.8f, 0);
        }
       
    }
}
