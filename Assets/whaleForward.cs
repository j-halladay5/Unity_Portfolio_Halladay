using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class whaleForward : MonoBehaviour
{
    public float swimSpeed = 1f;
    public GameObject whale;
    private bool whaleflag = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject whale = GameObject.Find("SpermWhaleLowPoly");
    }

    // Update is called once per frame
    void Update()
    {
        if (whaleflag)
        {
            whale.transform.Translate(Vector3.back * Time.deltaTime * swimSpeed, Space.Self);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger hit by:" + other.gameObject.name);
        //whale.transform.Translate(Vector3.back * Time.deltaTime * swimSpeed, Space.Self);
        whaleflag = true;

    }
}
