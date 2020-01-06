using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShot : MonoBehaviour
{
    public GameObject player;
    public GameObject clone;
    public GameObject ammo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Mouse1)) {
         clone =    Instantiate(ammo,transform.position,transform.rotation);
            
        }
        if (player.transform.localScale == new Vector3(1, 1, 1))
        {
            clone.GetComponent<Rigidbody2D>().velocity = transform.right * -30f;
        }
        if (player.transform.localScale == new Vector3(-1, 1, 1))
        {
        
            clone.GetComponent<Rigidbody2D>().velocity = transform.right * 30f;
        }
        Destroy(clone, 0.5f);
    }
}
