using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public Vector3 m_SpeedRotation;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("coucou");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(m_SpeedRotation * Time.deltaTime);
    }
}
