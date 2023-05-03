using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDamager : MonoBehaviour
{
     public int damage = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if ( collision.gameObject.tag == "Friendly")
        {
            collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(damage);
        }
            //Destroy(collision.gameObject);
    }
}
