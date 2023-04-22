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
        AudioManager.instance.stopAll();
        AudioManager.instance.Play(_startPlayName);
    }


}
