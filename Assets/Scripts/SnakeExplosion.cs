using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeExplosion : MonoBehaviour
{   
    public GameObject myGameObject;
    public int damage = 50;
    public int intialDelay = 20;
    public int destroyDelay = 1;
    public AudioClip deathSound; // The audio clip to play upon death
    private AudioSource audioSource; // Reference to the audio source component
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Destroy(this.gameObject, intialDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if ( collision.gameObject.tag == "Enemy")
        {
            Vector3 objectPosition = transform.position;
            Instantiate(myGameObject, new Vector3(objectPosition.x, objectPosition.y, objectPosition.z), Quaternion.identity );
            collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(damage);
            Destroy(this.gameObject, destroyDelay);
        }
            //Destroy(collision.gameObject);
    }
}
