using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WayToDoor : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _targetRenderer;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _speed;
    
    private float _currentPosition;
    private float _finishPosition;

    private void Update()
    {
        _finishPosition = _targetRenderer.transform.position.x;
        _currentPosition = Mathf.MoveTowards(_currentPosition, _finishPosition, Time.deltaTime);
        _rigidbody2D.velocity = transform.right * _speed;
    }
}
