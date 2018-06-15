using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationFramerate : MonoBehaviour {

    [SerializeField]
    private int targetFramerate = 60;

    [SerializeField]
    private bool applyOnStart = true;

	[SerializeField]
	private bool applyOnUpdate = true;

	[SerializeField]
    private bool apply30OnApplicationFocus = true;

	void Start () 
    {
        if(applyOnStart) 
        {
            SetTargetFramerate(targetFramerate);
        }
	}

    private void OnApplicationPause(bool pause)
    {
        if(!pause && apply30OnApplicationFocus)
        {
            SetTargetFramerate(30);
        }
    }

	void Update()
	{
		if (applyOnUpdate)
		{
			SetTargetFramerate(targetFramerate);
		}
	}

    private void SetTargetFramerate(int fps) 
    {
        Application.targetFrameRate = fps;
    }
}
