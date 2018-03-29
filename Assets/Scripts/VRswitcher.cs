using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

[System.Serializable]
public class VRswitcher : NetworkBehaviour {

	public Material matL;
	public Material matR;
	public GameObject playercam;

	//public GameObject caml = null;
	//public GameObject camr = null;
	public GameObject cams = null;


	public Texture[] tL = new Texture[10];
	public Texture[] tR = new Texture[10];
	public float[] rot = new float[10];

	private Color c;

void Start () 
{
		if(isServer)
		{
			playercam.SetActive(false);
			//caml = GameObject.Find("Cam_L");
			//camr = GameObject.Find("Cam_R");
			cams = GameObject.Find("Cams");
		}
		if(!isServer)
		{
			playercam.SetActive(true);
		}
}

public void vrswitch(int i)
	{
		Cmdvrswitch(i);
	}

[Command]
private void Cmdvrswitch(int i)
	{
		StartCoroutine (switching(i));
	}

IEnumerator switching(int i)
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			
		yield return null;}
		
		matL.SetTexture("_Tex", tL[i]);	
		matR.SetTexture("_Tex", tR[i]);

		//Cam Rotation
		//caml.transform.eulerAngles = new Vector3(0,rot[i],0);
		//camr.transform.eulerAngles = new Vector3(0,rot[i],0);
		cams.transform.eulerAngles = new Vector3(0,rot[i],0);

		print ("texture : " +tL[i]);			
		print ("texture : " +tR[i]);

		Debug.Log ("VR Changed!");

		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			
			yield return null;
		}
	}

}
