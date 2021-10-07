using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{

    public GameObject platform;
    public float spawnWait = 4.0f;
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public Transform spawn4;
    public bool stop;
    public static float score = 0;
    public Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(platformSpawn());               //calls the coroutine
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + score;
    }

    IEnumerator platformSpawn()                   //coroutine for instantiating platforms
    {
        yield return new WaitForSeconds(spawnWait);

        while (!stop)
        {
            int spawnNumber = Random.Range(0, 4);
            Vector3 spawnLocation;
            if(spawnNumber == 0)
            {
                spawnLocation = spawn1.transform.position;      //gets the spawn location of spawn point 1
            }
            else if(spawnNumber == 1)
            {
                spawnLocation = spawn2.transform.position;      //gets the spawn location of spawn point 2
            }
            else if(spawnNumber == 2)
            {
                spawnLocation = spawn3.transform.position;      //gets the spawn location of spawn point 3
            }
            else
            {
                spawnLocation = spawn4.transform.position;      //gets the spawn location of spawn point 4
            }

            Instantiate(platform, spawnLocation + Vector3.zero, transform.rotation);     //instantiate the enemy at the spawn location we get above

            score = score + 4;


            yield return new WaitForSeconds(spawnWait);
        }

    }
}
