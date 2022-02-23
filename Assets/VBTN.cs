using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN : MonoBehaviour
{
    public GameObject info; // relevant information
    public GameObject review; // review of book
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);

        review.SetActive(false);
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        info.SetActive(false); // hide relevant info
        review.SetActive(true); // show review

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        info.SetActive(true); // show relevant info
        review.SetActive(false); // hide review
        
    }
}
