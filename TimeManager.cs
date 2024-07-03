using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static TimeManager _instance { get; set; }
    public float _beatsPreMinute = 120f;
    private float _beatInterval;
    private float _beatTimer;
    private float _updatedBPM;

    private bool _startBPM;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        _beatInterval = 60f / _beatsPreMinute;
        _beatTimer = _beatInterval;
        _updatedBPM = _beatsPreMinute;
    }

    public void BPMStart()
    {
        _startBPM = true;
    }
    public void BPMStop()
    {
        _startBPM = false;
    }

    private void FixedUpdate()
    {
        if (_startBPM)
        {
            _beatTimer -= Time.fixedDeltaTime;
            if (_beatTimer <= 0)
            {

                if (_beatsPreMinute <= _updatedBPM || _beatsPreMinute >= _updatedBPM)
                {
                    _updatedBPM = _beatsPreMinute;
                    _beatInterval = 60f / _updatedBPM;
                    _beatTimer += _beatInterval;
                }
                else
                {
                    _beatTimer += _beatInterval;
                }
                ClapManager._instance.ClapSampleLogic();
                Debug.Log("Time Manager: Beat");
            }
        }
    }
}
