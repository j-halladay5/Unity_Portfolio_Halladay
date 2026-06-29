using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriggerClam : MonoBehaviour
{

    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("Open");

    }
}
