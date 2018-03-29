using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using System.Collections.Generic;

public class MainScene_Startup : MonoBehaviour {

	public Material vl;
	public Material vr;
	public Texture tl;
	public Texture tr;

	public Color def;
	private Color c;

void Start () 
	{
		c.r=0.0f;
		c.g=0.0f;
		c.b=0.0f;
		fdein();
		Debug.Log ("Textures_Reset!!!");
	}

	void Update()
	{
		//Debug.Log ("Connections = " +NetworkManager.singleton.numPlayers.ToString());
		Debug.Log ("Objects = " +NetworkServer.objects.Count.ToString ());
		Debug.Log ("Connections = " +NetworkServer.connections.Count.ToString ());
		if(NetworkServer.objects.Count <= 5 && NetworkManager.singleton.numPlayers < 1)
		{ 
			fde();

		}
			

	}

void fde()
		{
		StartCoroutine (fading());
		}
	IEnumerator fading()
	{
		for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{
			c.r = a;c.g = a;c.b = a;	
			vl.SetColor ("_Tint", c);			
			vr.SetColor ("_Tint", c);			
			yield return null;
		}

		vl.SetTexture ("_Tex", tl);
		vr.SetTexture ("_Tex", tr);

		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{
			c.r = b;c.g = b;c.b = b;	
			vl.SetColor ("_Tint", c);			
			vr.SetColor ("_Tint", c);			
			yield return null;
		}
	}
void fdein()
	{
		StartCoroutine (fadingin());
	}
	IEnumerator fadingin()
	{
		for (float a = 0.0f; a <= 0.5f; a += 0.01f )
		{
			c.r =a;c.g = a;c.b =a;
			vl.SetColor ("_Tint", c);			
			vr.SetColor ("_Tint", c);			
			yield return null;
		}
	}
}
