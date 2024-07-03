using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerBottons : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private BoxCollider2D _boxCollider;
    private bool _enabled;
    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _boxCollider = GetComponent<BoxCollider2D>();
    }
    private void OnMouseDown()
    {
        if (_enabled)
        {
            _enabled = false;
            _spriteRenderer.color = new Color(0.1333333f, 0.1647059f, 0.1960784f);
        }
        else
        {
            _enabled = true;
            _spriteRenderer.color = new Color(0.1033286f, 0.1365699f, 0.1698113f);
        }
    }

}
