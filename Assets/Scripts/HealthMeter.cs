using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMeter : MonoBehaviour
{
    public GameObject heartPrefab; // The heart prefab to instantiate
    public int numHearts = 3; // The number of hearts to spawn
    private int remainingHearts; // The number of remaining hearts

    void Start()
    {
        remainingHearts = numHearts - 1;
        for (int i = 0; i < numHearts; i++)
        {
            GameObject heart = Instantiate(heartPrefab, transform.position + Vector3.down * 1 + Vector3.right * 3 * i, Quaternion.identity);
            heart.tag = "Heart";
        }
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
