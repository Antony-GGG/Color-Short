using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class PouringSoundEffects : MonoBehaviour
{
    public AudioSource pouringSoundEffect;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("soundVolume"))
        {
            PlayerPrefs.SetFloat("soundVolume", 1);
        }

        pouringSoundEffect = GetComponent<AudioSource>();

        pouringSoundEffect.volume = PlayerPrefs.GetFloat("soundVolume");
    }
}
