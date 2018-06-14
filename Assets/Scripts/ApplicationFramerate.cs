using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationFramerate : MonoBehaviour {

    [SerializeField]
    private int targetFramerate = 60;

    [SerializeField]
    private bool applyOnStart = true;

    [SerializeField]
    private bool applyOnApplicationFocus = true;


	// Use this for initialization
	void Start () 
    {
        if(applyOnStart) 
        {
            ApplyTargetFramerate();
        }
	}

    private void OnApplicationPause(bool pause)
    {
        if(!pause && applyOnApplicationFocus)
        {
            ApplyTargetFramerate();
        }
    }

    private void ApplyTargetFramerate() 
    {
        Application.targetFrameRate = targetFramerate;
    }
}
