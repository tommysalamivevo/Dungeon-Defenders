using UnityEngine;
using System.Collections;

public class AudioLooper : MonoBehaviour {

    public AudioClip clipToLoop;
    private AudioSource audioSource;
    private float clipLength;

    void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clipToLoop;
        audioSource.loop = false;
        clipLength = clipToLoop.length;
        StartCoroutine(LoopClip());
    }

    IEnumerator LoopClip () {
        while (true) {
            audioSource.Play();
            yield return new WaitForSeconds(clipLength);
        }
    }
}
