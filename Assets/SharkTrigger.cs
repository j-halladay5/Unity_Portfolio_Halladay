using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SharkTrigger : MonoBehaviour
{
    public Animator sharkAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sharkAnimator = GameObject.Find("Shark_Animated").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("SharkTime");
            sharkAnimator.SetTrigger("DoSpecial");
        }
    }
}
