using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMover : MonoBehaviour
{
    // Public variables
    public Transform[] waypoints;
    public float speed = 5f;
    public AudioSource audioSource;
    public AudioClip soundEffect;

    // Private variables
    private int currentWaypoint = 0;

    // Private variable to store a reference to the Currency script
    private Currency currencyScript;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Invoke the PlaySoundEffect method every 6 seconds, starting after 1 second
        InvokeRepeating("PlaySoundEffect", 1f, 6f);

        currencyScript = FindObjectOfType<Currency>();
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate distance to next waypoint
        float distance = Vector3.Distance(transform.position, waypoints[currentWaypoint].position);

        // If we are close enough to the current waypoint, move to the next one
        if (distance < 0.1f)
        {
            currentWaypoint++;

            // If we have reached the end of the track, reset to the beginning
            if (currentWaypoint >= waypoints.Length)
            {
                currentWaypoint = 0;
            }
        }

        // Move towards the current waypoint
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypoint].position, speed * Time.deltaTime);
    }

    public AudioClip[] soundEffects; // an array of audio clips to play
    private int currentSoundEffectIndex = 0; // the index of the current sound effect to play

    void PlaySoundEffect()
    {
        audioSource.PlayOneShot(soundEffects[currentSoundEffectIndex]);
        currentSoundEffectIndex = (currentSoundEffectIndex + 1) % soundEffects.Length; // toggle to the next sound effect in the array
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Friendly"))
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (currencyScript != null)
        {
            currencyScript.IncreaseCurrency();
        }
    }

}
