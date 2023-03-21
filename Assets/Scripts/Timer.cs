using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public delegate void OnTimerEnded();

    public IEnumerator InvokeDelayed(int duration, OnTimerEnded callback)
    {
        yield return new WaitForSeconds(duration * 60);
        callback();
    }
}
