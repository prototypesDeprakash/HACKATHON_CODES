using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoff : MonoBehaviour
{
    public GameObject displayofwebcam;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("true");
            displayofwebcam.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            displayofwebcam.SetActive(false);
        }
        
    }
}
