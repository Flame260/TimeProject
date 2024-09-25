using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Gamemanager gamemanager;
    private bool hit;
    public void Start()
    {
        gamemanager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Gamemanager>();
        hit = false;
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(hit)return;
        
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Collectible")
        {
            Destroy(collision.gameObject);
            gamemanager.AddScore();
            hit= true;
             Destroy(gameObject);
        }
    }
    
    
}
