using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class directcam : MonoBehaviour
{
    [SerializeField] private RawImage img = default;

    private WebCamTexture webcam;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("WORKING");
        webcam = new WebCamTexture();
        if (!webcam.isPlaying) webcam.Play();
        img.texture = webcam;
    }

   
}
