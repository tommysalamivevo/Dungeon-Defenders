using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public int numSpawns = 5;
    public int spawnDelay = 5;
    public int intialDelay = 2;
    public float locationX = 0;
    public float locationY = 0;
    //int spawnDelay = 5;
    public GameObject myGameObject;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(intialDelay);
        for(int i = 0; i< numSpawns; i++)
        {
            yield return new WaitForSeconds(spawnDelay);
            Instantiate(myGameObject, new Vector3(locationX, locationY, 0f), Quaternion.identity);
        }
    }
}
