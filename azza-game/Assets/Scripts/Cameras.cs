using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{

    public GameObject camera1;
    public GameObject camera2;
    public GameObject cameraPlayer;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            ToggleCamera();
        }
    }

    void ToggleCamera()
    {
        if(cameraPlayer.activeInHierarchy)
        {
            cameraPlayer.SetActive(false);
            camera1.SetActive(true);
        }
        else if (camera1.activeInHierarchy)
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
        else
        {
            camera2.SetActive(false);
            cameraPlayer.SetActive(true);
        }
    }

}
