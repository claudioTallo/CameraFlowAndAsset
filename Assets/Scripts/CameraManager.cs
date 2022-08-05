using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] cameras;
    int camNumber;

    void Start()
    {
        for(int i = 0; i < cameras.Length; i++)
        {
            cameras[i].SetActive(false);
        }

        if(cameras.Length > 0)
        {
            cameras[0].SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            camNumber++;
            if (camNumber < cameras.Length)
            {
                cameras[camNumber - 1].SetActive(false);
                cameras[camNumber].SetActive(true);
                
            }
            else
            {
                cameras[camNumber - 1].SetActive(false);
                camNumber = 0;
                cameras[camNumber].SetActive(true);
                
            }
        }

    }
        
    
}
