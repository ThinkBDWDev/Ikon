using UnityEngine;
using System.Collections;

public class Device_Setup : MonoBehaviour {

	// Use this for initialization
	void Awake () {

		if(SystemInfo.deviceType == DeviceType.Handheld)
		{
		Application.targetFrameRate = 60;
		}
	
	}
	

}
