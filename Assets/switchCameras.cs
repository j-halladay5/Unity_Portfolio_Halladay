using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class switchCameras : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Camera monofirst;
    public Camera monothird;
    public GameObject ThirdCameraRig;
    public GameObject CameraRig;

    //public Camera leftEye;
    //public Camera rightEye;
    private int viewMode = 0;
    void Start()
    {
        switchView();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            viewMode = (viewMode + 1) % 4;
            switchView();
        }
    }

    void switchView()
    {
        monofirst.enabled = (viewMode == 0);
        monothird.enabled = (viewMode == 1);
        CameraRig.SetActive(viewMode == 2);
        ThirdCameraRig.SetActive(viewMode == 3);

    }

}
