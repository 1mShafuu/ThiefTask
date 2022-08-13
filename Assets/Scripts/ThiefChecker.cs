using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ThiefChecker : MonoBehaviour
{
    [SerializeField] public UnityEvent OnReached = new UnityEvent();
    [SerializeField] public UnityEvent OnLose = new UnityEvent();
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            OnReached.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        OnLose.Invoke();
    }
}
