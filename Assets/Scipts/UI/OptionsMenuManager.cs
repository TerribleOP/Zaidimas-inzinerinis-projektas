using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;
public class OptionsMenuManager : MonoBehaviour
{
    public TMP_Dropdown graphicsDropdown;
    public Slider masterVol, musicVol, SFXVol;
    public AudioMixer mainAudioMixer;
    
    public void ChangeGraphicsQuality()
    {
        QualitySettings.SetQualityLevel(graphicsDropdown.value);
    }
    public void ChangeMasterVolume()
    {
        mainAudioMixer.SetFloat("MasterVolume", masterVol.value);
    }
    public void ChangeSFXVolume()
    {
        mainAudioMixer.SetFloat("SFXVolume", SFXVol.value);
    }
    public void ChangeMusicVolume()
    {
        mainAudioMixer.SetFloat("MusicVolume", musicVol.value);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
