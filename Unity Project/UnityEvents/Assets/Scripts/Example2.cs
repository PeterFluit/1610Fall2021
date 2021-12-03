using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Example2 : MonoBehaviour
{
    public UnityEvent awakeEvent, startEvent, onEnable;
    public float holdTime;

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(holdTime);
        startEvent.Invoke();
    }

    private void OnEnable()
    {
        onEnableEvent.Ivoke();
    }
}
