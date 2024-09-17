using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    public float Timer = 0f;
    float playerScore = 0f;
    public float spawntimer = 0f;
    public float spawninterval = 0f;

    movement playerScript;
    public GameObject Enemy;
    public GameObject Player;
    public TextMeshProUGUI gametimer;
    public TextMeshProUGUI myscore;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerScript = Player.GetComponent<movement>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer+=Time.deltaTime;
        spawntimer += Time.deltaTime;
        if (spawntimer >= spawninterval)
        {
            spawntimer = 0f;
            Instantiate(Enemy);

        }
        gametimer.text = "Time:" + Mathf.Round(Timer).ToString();
    }
    void FixUpdate()
    {
           
    }
}
