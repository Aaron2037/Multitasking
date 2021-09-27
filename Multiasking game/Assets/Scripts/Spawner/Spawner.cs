using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //This is the spawner that Professor Warren gave to us
    public GameObject enemy1Prefab;
    public GameObject enemy2Prefab;
    float spawnTime = 0;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTime < 0)
        {
            CreateNewObject();
            spawnTime = Random.Range(3f, 6f);
        }
        spawnTime -= Time.deltaTime;
    }
    void CreateNewObject()
    {
        int whichObject = Random.Range(0, 4);

        if (whichObject == 0)
        {
            GameObject newPellet = (GameObject)Instantiate(enemy1Prefab);
            newPellet.transform.position = transform.position + new Vector3(0, 0.5f, 0);
            newPellet.transform.rotation = transform.rotation;
        }
        else
        {
            GameObject newCar = (GameObject)Instantiate(enemy2Prefab);
            newCar.transform.position = transform.position;
            newCar.transform.rotation = transform.rotation;
        }
    }
}
