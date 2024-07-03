using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayButtonScirpt : MonoBehaviour
{
    private SpriteRenderer _spriteRender;
    private BoxCollider2D _boxCollider;
    private bool _enabled;

    // Start is called before the first frame update
    void Start()
    {
        _spriteRender = GetComponent<SpriteRenderer>();
        _boxCollider = GetComponent<BoxCollider2D>();
        _spriteRender.color = new Color(0.5568628f, 0.5568628f, 0.5568628f);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TurnOnOffBotton();
        }
    }

    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            TurnOnOffBotton();
        }
    }
    private void TurnOnOffBotton()
    {
        if (_enabled)
        {
            _enabled = false;
            TimeManager._instance.BPMStop();
            _spriteRender.color = new Color(0.5568628f, 0.5568628f, 0.5568628f);
        }
        else
        {
            _enabled = true;
            TimeManager._instance.BPMStart();
            _spriteRender.color = new Color(0.1452812f, 0.6603774f, 0.05918475f);
        }
    }
}
