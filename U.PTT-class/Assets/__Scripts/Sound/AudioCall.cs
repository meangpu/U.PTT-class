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
        Debug.Log($"{_aud}");
        _aud.stopAll();
        _aud.Play(_startPlayName);
    }


}
