using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public int numSpawns = 5;
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
        for(int i = 0; i< numSpawns; i++)
        {
            yield return new WaitForSeconds(5);
            Instantiate(myGameObject, new Vector3(0f, 0f, 0f), Quaternion.identity);
        }
    }
}
