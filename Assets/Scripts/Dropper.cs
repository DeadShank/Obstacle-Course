using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    new MeshRenderer renderer;
    Rigidbody rb;
    [SerializeField] private float timeToWait;

    private void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rb.useGravity = false;
    }
    void Update()
    {
        Timer();
    }

    private void Timer()
    {
       if(Time.time > timeToWait)
        {
            rb.useGravity = true;
            renderer.enabled = true;
        }
    }
}
