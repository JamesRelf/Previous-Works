using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioClip bedSheets;
    [SerializeField] AudioClip bodyPickup;
    [SerializeField] AudioClip buying;
    [SerializeField] AudioClip candle;
    [SerializeField] AudioClip candleExtinguish;
    [SerializeField] AudioClip chewing;
    [SerializeField] AudioClip collapsing;
    [SerializeField] AudioClip grainSack;
    [SerializeField] AudioClip[] footsteps;
    [SerializeField] AudioClip[] rope;
    [SerializeField] AudioClip[] fork;

    AudioSource audioSource;
    float defaultLevel = 0.5f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void AudioBedSheets()
    {
        audioSource.PlayOneShot(bedSheets, defaultLevel);
    }

    public void AudioPause()
    {
        audioSource.Pause();
    }

    public void AudioCollapse()
    {
        audioSource.PlayOneShot(collapsing, defaultLevel);
    }

    public void AudioGrain()
    {
        audioSource.PlayOneShot(grainSack, defaultLevel);
    }

    public AudioClip AudioFootsteps()
    {
        return audioSource.clip = footsteps[Random.Range(0, footsteps.Length)];
    }
    
    public void AudioStop()
    {
        audioSource.Stop();
    }

    public void AudioChewing()
    {
        audioSource.PlayOneShot(chewing, defaultLevel);
    }

    public void AudioSnuff()
    {
        audioSource.PlayOneShot(candleExtinguish, defaultLevel - 0.3f);
    }

    public void AudioCandle()
    {
        audioSource.PlayOneShot(candle, defaultLevel + 1);
    }

    public void AudioFork()
    {
        audioSource.PlayOneShot(fork[Random.Range(0, fork.Length)], defaultLevel);
    }
    
    public void AudioRope()
    {
        audioSource.PlayOneShot(rope[Random.Range(0, rope.Length)], defaultLevel);
    }

    public void AudioPickup()
    {
        audioSource.PlayOneShot(bodyPickup, defaultLevel + 1f);
    }

    public void AudioBuying()
    {
        audioSource.PlayOneShot(buying, defaultLevel);
    }
}
