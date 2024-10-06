using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{
    public string scenename;
    public GameObject player;
    public void Gameplay()
    {
        SceneManager.LoadScene("game");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "Player") 
        {
            SceneManager.LoadScene(scenename);
        }
    }
}

