using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    public static EventManager instance;

    public event Action onCountScoreTriggerEnter;

    private void Awake()
    {
        instance = this; 
    }
    void Start()
    {

    }

    public void CountScoreTrigger()
    {
        if(onCountScoreTriggerEnter != null)
        {
            onCountScoreTriggerEnter();
        }

       // onCountScoreTriggerEnter?.Invoke();
    }
}
