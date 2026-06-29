using UnityEngine;

public class whaleSoundTrigger : MonoBehaviour
{

    public AudioSource audioSource; 
    public AudioClip soundClip;       
    void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (soundClip != null)
                audioSource.PlayOneShot(soundClip);
            else
                audioSource.Play();
        }
    }
}

