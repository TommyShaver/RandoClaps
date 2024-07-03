using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClapManager : MonoBehaviour
{
    public static ClapManager _instance { get; set; }
    public AudioClip[] _clapSamples;
    public AudioSource[] _audioScourceVoices;
    private bool[] _playerOn = new bool[9];
    private bool[] _isRandom = new bool[9];
    public int[] _samplechoice = new int[16];
    

    //Set up logic -----------------------------------------------------
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this);
        }
        else
        {
            _instance = this;
        }

    }

    private void Start()
    {
        for (int i = 0; i < _audioScourceVoices.Length; i++)
        {
           GetComponent<AudioSource>();
        }
        for(int j = 0; j < _playerOn.Length; j++) 
        {
            _playerOn[j] = false;
        }
        for(int k = 0; k < _isRandom.Length; k++)
        {
            _isRandom[k] = false;
        }
        APitch(1);
        BPitch(1);
        CPitch(1);
        DPitch(1);
        APan(0);
        BPan(0);
        CPan(0);
        DPan(0);

    }

    //In game logic ------------------------------------------------------
    public void ClapSampleLogic()
    {
        if (_playerOn[0])
        {
            SampleStartFunction(0, _samplechoice[0], _isRandom[0]);
        }
        if (_playerOn[1])
        {
            SampleStartFunction(1, _samplechoice[1], _isRandom[1]);
        }
        if (_playerOn[2])
        {
            SampleStartFunction(2, _samplechoice[2], _isRandom[2]);
        }
        if (_playerOn[3])
        {
            SampleStartFunction(3, _samplechoice[3], _isRandom[3]);
        }
    }
    public void WhichSample(int whichPlayer, int sample)
    {
        _samplechoice[whichPlayer] = sample;
    }
    public void IsPlayerOn(bool isOn, int whichPlayer)
    {
        _playerOn[whichPlayer] = isOn;

    }
    public void IsTimeRandom(bool isRadon, int whichPlayer)
    {
        _isRandom[whichPlayer] = isRadon;
    }
    private float ReturnRandom()
    {
        float randomNumber = UnityEngine.Random.Range(0.0f, 0.05f);
        return randomNumber;
    }
    private void SampleStartFunction(int scource, int clip, bool isRandom)
    {
        float time;
        if(isRandom) 
        {
             time = ReturnRandom(); 
        }
        else 
        {
             time = 0; 
        }
        StartCoroutine(StartSample(time, _audioScourceVoices[scource], _clapSamples[clip]));
    }
    private IEnumerator StartSample(float _time, AudioSource _playerName, AudioClip _clip)
    {
        yield return new WaitForSeconds(_time);
        _playerName.clip = _clip;
        _playerName.Play();
    }

    //Knobs for UI ============================================================================
    //A ---------------------------------------------------------------------------------------
    public void APitch(float _aPitch)
    {
        _audioScourceVoices[0].pitch = _aPitch;
    }
    public void APan(float _aPan)
    {
        _audioScourceVoices[0].panStereo = _aPan;
    }

    //B ---------------------------------------------------------------------------------------
    public void BPitch(float _aPitch)
    {
        _audioScourceVoices[1].pitch = _aPitch;
    }
    public void BPan(float _aPan)
    {
        _audioScourceVoices[1].panStereo = _aPan;
    }
    // C -----------------------------------------------------------------------------------------
    public void CPitch(float _aPitch)
    {
        _audioScourceVoices[2].pitch = _aPitch;
    }
    public void CPan(float _aPan)
    {
        _audioScourceVoices[2].panStereo = _aPan;
    }
    // D ------------------------------------------------------------------------------------------
    public void DPitch(float _aPitch)
    {
        _audioScourceVoices[3].pitch = _aPitch;
    }
    public void DPan(float _aPan)
    {
        _audioScourceVoices[3].panStereo = _aPan;
    }
}
