using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject Enemy;
    public float spawntimer=0f;
    public float spawninterval=0f;

    public float Timer= 0f;
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
    }
}
