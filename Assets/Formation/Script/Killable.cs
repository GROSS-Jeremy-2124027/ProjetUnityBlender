using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Killable : MonoBehaviour
{
    public UnityEvent OnDie;

    public void Die()
    {
        OnDie?.Invoke();
    }

    public void DebugDie()
    {
        Debug.Log("je meurs");
    }
}
