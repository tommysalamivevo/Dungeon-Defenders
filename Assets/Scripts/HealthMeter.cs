using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMeter : MonoBehaviour
{
    public GameObject heartPrefab; // The heart prefab to instantiate
    public int numHearts = 3; // The number of hearts to spawn
    public int remainingHearts; // The number of remaining hearts
    public float locationX = 0;
    public float locationY = 0;

    void Start()
    {
        remainingHearts = numHearts - 1;
        for (int i = 0; i < numHearts; i++)
        {
            GameObject heart = Instantiate(heartPrefab, new Vector3(locationX + (2 * i), locationY, 0f), Quaternion.identity);
            heart.tag = "Heart";
        }
        remainingHearts++;
    }

    void DestroyHeart()
    {
        
        remainingHearts--;
        GameObject[] hearts = GameObject.FindGameObjectsWithTag("Heart");
        Destroy(hearts[numHearts - 2]); // destroy the heart at the correct index

        if (remainingHearts == -1)
        {
            Destroy(gameObject); // Destroy this unit if there are no more hearts left
            return;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (remainingHearts >= 0)
            {
                DestroyHeart();
            }
        }
    }
}
