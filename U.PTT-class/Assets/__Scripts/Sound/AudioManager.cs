using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    // FindObjectOfType<AudioManager>().Play("soundName");
    // AudioManager.instance.Play("soundName");

    public Sound[] sounds;
    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            // make onject go across scene
        }
        else
        {
            Destroy(gameObject);
        }

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volumn;
            s.source.pitch = s.pitch;
            s.source.outputAudioMixerGroup = s.mixerGroup;
            s.source.spatialBlend = s.blend;
            s.source.loop = s.loop;
        }
    }

    public void Play(string name)
    {
        Debug.Log($"play {name}");
        Sound s = Array.Find(sounds, sound => sound.audioName == name);
        if (s == null || s.source == null)
        {
            Debug.Log("ERROR");
            return;
        }
        s.source.Play();
    }


    public void PlayOne(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.audioName == name);
        if (s == null || s.source == null)
        {
            Debug.Log("ERROR");
            return;
        }
        s.source.PlayOneShot(s.clip, s.volumn);
    }

    public void PlayAddPitch(string name, float addingValue, bool doPlay = true)
    {
        Sound s = Array.Find(sounds, sound => sound.audioName == name);
        if (s == null || s.source == null)
        {
            Debug.Log("ERROR");
            return;
        }
        s.pitch += addingValue;
        s.source.pitch = s.pitch;
        if (doPlay)
        {
            s.source.Play();
        }
    }

    public void stopAll()
    {
        Debug.Log($"stop");
        foreach (Sound s in sounds)
        {
            s.source.Stop();
        }
    }


}
