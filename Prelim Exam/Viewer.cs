using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viewer : MonoBehaviour
{

    public GameObject ReenoView;
    public GameObject SkulloView;

    public void OpenPanel()
    {
        if(ReenoView!= null)
        {
            ReenoView.SetActive(true);
        }
    }
}
