using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyai : MonoBehaviour
{
    public GameObject player;
    public GameObject Death;
    public float speed;
    private bool touch; 

    private float distance;

    // Start is called before the first frame update
    void Start()
    {
      player= GameObject.FindGameObjectWithTag("Player");
      Death= GameObject.FindGameObjectWithTag("Death");
      touch = false; 
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;


        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(Vector3.forward *angle);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (touch) return; 
        if(collision.collider.gameObject.tag == "Player")
        {
            touch=true;
            push();
           
        }
        else
        {
            touch=false;
        }   
    }
    void push()
    {
        speed =30;
        distance = Vector2.Distance(transform.position, Death.transform.position);
        Vector2 direction = Death.transform.position - transform.position;

    }
}
