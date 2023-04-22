using UnityEngine;

public class AudioCall : MonoBehaviour
{
    AudioManager _aud;
    string _startPlayName;


    private void Start()
    {
        _aud = FindObjectOfType<AudioManager>();
        _aud.stopAll();
        _aud.Play(_startPlayName);
    }

}
