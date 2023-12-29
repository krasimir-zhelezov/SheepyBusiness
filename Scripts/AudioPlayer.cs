using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField] AudioClip[] sounds;
    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        //Debug.Log(sounds[0]);
    }

    public void PlayAudio(int index)
    {
        source.clip = sounds[index];
        source.PlayOneShot(source.clip);
    }
}
