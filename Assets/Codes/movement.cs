using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float accel = 1;
    public float horM = 1;
    public float vertM = 1;
    public float walkspeed = 2;

    public Rigidbody2D rb;
    public Camera cam;
    Vector2 mousePos;
    public float runspeed = 2f; 
    // Start is called before the first frame update
    void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();

    }

   

    // Update is called once per frame
    void Update()
    {
         mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    private void FixedUpdate()
    {
        Vector3 currentDir = Dir();
        currentDir.x *= horM;
        currentDir.y *= vertM;
        transform.Translate(currentDir * accel, Space.World);
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y,lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        if(Input.GetKey(KeyCode.LeftShift))
        {
            horM = runspeed;
            vertM = runspeed;

        }
        else
        {
            horM = walkspeed;
            vertM = walkspeed;

        }

    }
    public Vector3 Dir()
    {
        //unity default axis provide a value between -1 to 1
        //in the case of vertial,thats w=1 amd s=-1 
        float y = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        //construct our vector out of the vertical and horizontal axis
        Vector3 myDir = new Vector3(x, y, 0);
        //return the value
        return myDir;
    }
}
