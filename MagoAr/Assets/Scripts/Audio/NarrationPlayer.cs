using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(AudioSource))]
public class NarrationPlayer : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip[] ListAudio;
    int i;
    bool isPlayAudio = false;

    [SerializeField] UnityEvent whenIsPlayAudio;
    [SerializeField] UnityEvent whenFinishTheAudio;

    private void Start()
    {
        i = 0;
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (isPlayAudio)
        {
            if (!audioSource.isPlaying)
            {
                isPlayAudio = false;
                i++;
                whenFinishTheAudio.Invoke();
            }
        }
    }

    public void PlayAudioInOrder()
    {
        if (!isPlayAudio && ListAudio.Length > 0 && i < ListAudio.Length)
        {
            whenIsPlayAudio.Invoke();
            isPlayAudio = true;
            audioSource.clip = ListAudio[i];
            audioSource.Play();
        }
    }
}
