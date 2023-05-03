using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeSpawner : MonoBehaviour
{
    public int numSpawns = 5;
    public int spawnDelay = 5;
    public int intialDelay = 2;
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
            Vector3 objectPosition = transform.position;
            yield return new WaitForSeconds(spawnDelay);
            Instantiate(myGameObject, new Vector3(objectPosition.x, objectPosition.y+1, 0f), Quaternion.identity);
        }
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }

}
