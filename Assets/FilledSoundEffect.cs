using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class FilledSoundEffect : MonoBehaviour
{
    public AudioSource filledSoundEffect;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("soundVolume"))
        {
            PlayerPrefs.SetFloat("soundVolume", 1);
        }

        filledSoundEffect = GetComponent<AudioSource>();

        filledSoundEffect.volume = PlayerPrefs.GetFloat("soundVolume");
    }
}
