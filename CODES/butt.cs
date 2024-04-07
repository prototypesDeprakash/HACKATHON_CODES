using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class butt : MonoBehaviour
{
    public GameObject image;

    public void buttonClicked()
    {
        if (image.activeInHierarchy == true)
        {
            image.SetActive(false);
        }
        else
        {
            image.SetActive(true);
        }
    }

}
