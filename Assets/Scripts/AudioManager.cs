using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource srcBgMusic;
    [SerializeField] AudioSource srcSfx;
    public AudioClip bgMusic;
    public AudioClip[] sfx;

    private void Start()
    {
        srcBgMusic.clip = bgMusic;
        srcBgMusic.Play();
    }

    public void PlaySfx(AudioClip sfxClip) 
    {
        //reproducir solo 1 vez
        srcSfx.PlayOneShot(sfxClip);
    }
    public void PlaySfx(int sfxClipIndex)
    {
        //reproducir solo 1 vez
        srcSfx.PlayOneShot(sfx[sfxClipIndex]);
    }
}
