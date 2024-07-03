using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class AllTheKnobs : MonoBehaviour
{
    [SerializeField] AudioMixer _audioMixer;

    private void Start()
    {
        AVolumeSlider(0);
    }

    //A Clap Player ============================================================================
    public void AVolumeSlider(float volume)
    {
        _audioMixer.SetFloat("AVolumeSlider", volume);
    }

    //B Clap Player ============================================================================
    public void BVolumeSlider(float volume)
    {
        _audioMixer.SetFloat("BVolumeSlider", volume);
    }
    //C Clap Player ============================================================================
    public void CVolumeSlider(float volume)
    {
        _audioMixer.SetFloat("CVolumeSlider", volume);
    }
    //D Clap Player ============================================================================
    public void DVolumeSlider(float volume)
    {
        _audioMixer.SetFloat("DVolumeSlider", volume);
    }
    public void GlonbalVolumeSlider(float volume)
    {
        _audioMixer.SetFloat("GlobalVolumeSlider", volume);
    }
}
