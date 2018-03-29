using UnityEngine;
using System.Collections;

public class fps60 : MonoBehaviour {

	void Awake()
	{
		Application.targetFrameRate = 60;
	}
}
