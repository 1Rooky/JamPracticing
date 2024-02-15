using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource SFXSource;

    [Header("Audio Clip")]
    public AudioClip [] BGs;
   
    public AudioClip death;
    public AudioClip shot;

    public static AudioManager instance { get; private set; }

    private void Awake()
    {
        if (instance == null)
        {

            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);   
    }

    private void Start()
    {
        musicSource.clip = BGs[0];
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void PlayBG()
    {
        int index = Random.Range(0, BGs.Length);
        musicSource.clip = BGs[index];
        musicSource.Play();
    }
}
