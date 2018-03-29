using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tetsing : MonoBehaviour {

	public InputField input;
		
	public void save()
	{
		string infoIn = input.text;
		PlayerPrefs.SetString ("data", infoIn);
	}

	public void load()
	{
		string infoOut = PlayerPrefs.GetString ("data","");
		input.text = infoOut;
		Debug.Log ("info = " +infoOut);
	}

	void Update()
	{
		Debug.Log ("Hello");
	}
}
