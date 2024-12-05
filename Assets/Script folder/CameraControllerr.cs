using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerr : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject clownCam;
    public GameObject monsterCam;

    void Start()
    {
        clownCam.SetActive(false);
        monsterCam.SetActive(false);
        if (mainCamera == null)
        {
            mainCamera.SetActive(true);
        }
    }

    void Update()
    {
        if(clownCam == null && monsterCam == null )
        {
            mainCamera.SetActive(true);
        }
        else if (clownCam != null && monsterCam == null || clownCam == null && monsterCam != null)
        {
            mainCamera.SetActive(false);
        }
    }
}
