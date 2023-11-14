using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource srcBgMusic;
    [SerializeField] AudioSource srcSfx;
    public AudioClip bgMusic;
    public AudioClip sfx1;

    private void Start()
    {
        srcBgMusic.clip = bgMusic;
        srcBgMusic.Play();
    }
}
