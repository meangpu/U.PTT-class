using UnityEngine;

public class AudioCall : MonoBehaviour
{
    AudioManager _aud;
    [SerializeField] string _startPlayName;


    private void Start()
    {
        StopAndPlay();
    }

    void StopAndPlay()
    {
        _aud = FindObjectOfType<AudioManager>();
        _aud.stopAll();
        _aud.PlayOne(_startPlayName);
    }


}
