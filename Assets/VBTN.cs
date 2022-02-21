using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN : MonoBehaviour
{
    public GameObject summary;
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
        summary.SetActive(true);

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        summary.SetActive(false);
        
    }
}
