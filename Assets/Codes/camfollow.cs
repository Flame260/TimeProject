using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class camfollow : MonoBehaviour
{
    public Transform myTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = new Vector3(myTarget.position.x, transform.position.y, transform.position.z);
        transform.position = target;
    }
}
