using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public TextMeshProUGUI bulletcount;
    public int bullets = 30;
    public float cooldown;
    public float atkspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform firepoint;
    public GameObject bulletPrefab;

    public float bulletforce = 1f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && cooldown <= 0)
        {
            if (bullets > 0)
            {
                Shoot();
            }
            cooldown=atkspeed;

        }
        else
        {
            cooldown-=Time.deltaTime;
        }
        bulletcount.text = "Bullets:"+bullets.ToString();
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab,firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.right * bulletforce, ForceMode2D.Impulse);
        bullets--;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Collectible")
        {
            bullets = bullets + 5;
            Destroy(collision.gameObject);
        }
    }
}

