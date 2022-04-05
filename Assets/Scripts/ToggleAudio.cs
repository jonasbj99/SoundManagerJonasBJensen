using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAudio : MonoBehaviour
{
    [SerializeField] private bool toggleMusic, toggleSpawn, toggleEffects;

    public void Toggle()
    {
        if (toggleMusic) SoundManager.instance.ToggleMusic();
        if (toggleSpawn) SoundManager.instance.ToggleSpawn();
        if (toggleEffects) SoundManager.instance.ToggleEffects();
    }
}
