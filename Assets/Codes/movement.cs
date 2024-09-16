using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float accel = 1;
    public float horM = 1;
    public float vertM = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Vector3 currentDir = Dir();
        currentDir.x *= horM;
        currentDir.y *= vertM;
        transform.Translate(Dir() * accel);
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
