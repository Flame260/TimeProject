using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Gamemanager gamemanager;
    public void Start()
    {
        gamemanager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Gamemanager>();
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Collectible")
        {
            Destroy(collision.gameObject);
            gamemanager.AddScore();
        }
    }
    
    
}
