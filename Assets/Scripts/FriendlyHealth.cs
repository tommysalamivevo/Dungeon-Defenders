using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
            Destroy(gameObject);
    }

}
