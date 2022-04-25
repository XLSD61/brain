using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] GameObject soundOn;
    [SerializeField] GameObject soundOf;
    [SerializeField] GameObject vibrateOn;
    [SerializeField] GameObject vibrateOf;


    public void SoundOn()
    {
        soundOn.SetActive(false);
        soundOf.SetActive(true);
    }

    public void SoundOf()
    {
        soundOn.SetActive(true);
        soundOf.SetActive(false);
    }

    public void VibrateOn()
    {
        vibrateOn.SetActive(false);
        vibrateOf.SetActive(true);
        Vibration.isVibrate = false;
    }

    public void VibrateOf()
    {
        vibrateOn.SetActive(true);
        vibrateOf.SetActive(false);
        Vibration.isVibrate = false;
    }
}
