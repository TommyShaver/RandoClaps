using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnOffButton : MonoBehaviour
{
    private BoxCollider2D _boxCollider2D;
    private SpriteRenderer _spriteRenderer;
    [SerializeField] private int _buttonIndex;
    [SerializeField] private bool _enabled;
    

    public GameObject _onBarIndicator;
    // Start is called before the first frame update
    void Start()
    {
        _boxCollider2D = GetComponent<BoxCollider2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.color = new Color(0.5568628f, 0.5568628f, 0.5568628f);
    }

    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            if(_enabled) 
            {
                _enabled = false;
                ClapManager._instance.IsPlayerOn(_enabled, _buttonIndex);
                _onBarIndicator.SetActive(false);
                _spriteRenderer.color = new Color(0.5568628f, 0.5568628f, 0.5568628f);
            }
            else
            {
                _enabled = true;
                ClapManager._instance.IsPlayerOn(_enabled, _buttonIndex);
                _onBarIndicator.SetActive(true);
                _spriteRenderer.color = new Color(0.376f, 0.5032f, 0.8f);
            }
            
        }
    }
}
