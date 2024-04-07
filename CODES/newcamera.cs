using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newcamera : MonoBehaviour
{
    private WebCamTexture webcamTexture;
    public RawImage rawImage;

    void Start()
    {
        // Get the list of available webcams and choose the first one
        WebCamDevice[] devices = WebCamTexture.devices;
        string webcamName = devices[0].name;

        // Create a new WebCamTexture with the chosen webcam
        webcamTexture = new WebCamTexture(webcamName);

        // Apply the raw image from the webcam to the RawImage UI element
        if (rawImage != null)
        {
            rawImage.texture = webcamTexture;
        }

        // Start capturing from the webcam
        webcamTexture.Play();
    }

    void Update()
    {
        // Update the webcam texture if needed
        if (webcamTexture != null && !webcamTexture.isPlaying)
        {
            webcamTexture.Play();
        }
    }
}