using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN : MonoBehaviour
{
    public GameObject info; // relevant information
    public GameObject summary; // summary of book
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);

        summary.SetActive(false);
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        info.SetActive(false); // hide relevant info
        summary.SetActive(true); // show summary

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        info.SetActive(true); // show relevant info
        summary.SetActive(false); // hide summary
        
    }
}
