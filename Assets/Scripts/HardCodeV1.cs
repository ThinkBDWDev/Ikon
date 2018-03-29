using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class HardCodeV1 : NetworkBehaviour {
	
	public Material matL;
	public Material matR;
	public GameObject playercam;
	public Texture[] stL = new Texture[10];
	public Texture[] stR = new Texture[10];

	public Texture[] mnL = new Texture[10];
	public Texture[] mnR = new Texture[10];

	public Texture[] brL = new Texture[10];
	public Texture[] brR = new Texture[10];


	public Texture[] cnL = new Texture[10];
	public Texture[] cnR = new Texture[10];

	public Color def;
	private Color c;

	public GameObject cams = null;
		
	
void Start () 
	{
		if(isServer)
		{
			playercam.SetActive(false);
			cams = GameObject.Find("Cams");

		}
		if(!isServer)
		{
			playercam.SetActive(true);
		}

	}
	
	
	
	public void stp0()
			{Cmdstc0();}
	[Command]
	private void Cmdstc0()
	{StartCoroutine (fading0());}
		IEnumerator fading0()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
				{c.r = a;c.g = a;c.b = a;		
				matL.SetColor ("_Tint", c);			
				matR.SetColor ("_Tint", c);			yield return null;}
		int i = 0;	
		Debug.Log ("Done it!!!");
		matL.SetTexture("_Tex", stL[i]);	
		matR.SetTexture("_Tex", stR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);

		print ("texture : " +stL[i]);			
		print ("texture : " +stR[i]);
				for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
				{c.r = b;c.g = b;c.b = b;
				matL.SetColor ("_Tint", c);
				matR.SetColor ("_Tint", c);			yield return null;
		}}
		
		
	public void stp1()
	{Cmdstc1();}
	[Command]
	public void Cmdstc1()
	{StartCoroutine (fading1());}
	IEnumerator fading1()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 1;	
		matL.SetTexture("_Tex", stL[i]);	
		matR.SetTexture("_Tex", stR[i]);
		cams.transform.eulerAngles = new Vector3(0,0,0);

		print ("texture : " +stL[i]);			
		print ("texture : " +stR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
		
		
		
	public void stp2()
	{Cmdstc2();}
	[Command]
	public void Cmdstc2()
	{StartCoroutine (fading2());}
	IEnumerator fading2()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 2;	
		matL.SetTexture("_Tex", stL[i]);	
		matR.SetTexture("_Tex", stR[i]);
		cams.transform.eulerAngles = new Vector3(0,0,0);

		print ("texture : " +stL[i]);			
		print ("texture : " +stR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
		
		
		
	public void stp3()
	{Cmdstc3();}
	[Command]
	public void Cmdstc3()
	{StartCoroutine (fading3());}
	IEnumerator fading3()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 3;	
		matL.SetTexture("_Tex", stL[i]);	
		matR.SetTexture("_Tex", stR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +stL[i]);			
		print ("texture : " +stR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
		
		
	public void stp4()
	{Cmdstc4();}
	[Command]
	public void Cmdstc4()
	{StartCoroutine (fading4());}
	IEnumerator fading4()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 4;	
		matL.SetTexture("_Tex", stL[i]);	
		matR.SetTexture("_Tex", stR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +stL[i]);			
		print ("texture : " +stR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
		
		
	public void stp5()
	{Cmdstc5();}
	[Command]
	public void Cmdstc5()
	{StartCoroutine (fading5());}
	IEnumerator fading5()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 5;	
		matL.SetTexture("_Tex", stL[i]);	
		matR.SetTexture("_Tex", stR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +stL[i]);			
		print ("texture : " +stR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
		
		
	public void stp6()
	{Cmdstc6();}
	[Command]
	public void Cmdstc6()
	{StartCoroutine (fading6());}
	IEnumerator fading6()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 6;	
		matL.SetTexture("_Tex", stL[i]);	
		matR.SetTexture("_Tex", stR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +stL[i]);			
		print ("texture : " +stR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
		
		
	public void stp7()
	{Cmdstc7();}
	[Command]
	public void Cmdstc7()
	{StartCoroutine (fading7());}
	IEnumerator fading7()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 7;	
		matL.SetTexture("_Tex", stL[i]);	
		matR.SetTexture("_Tex", stR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +stL[i]);			
		print ("texture : " +stR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
		
		
	public void stp8()
	{Cmdstc8();}
	[Command]
	public void Cmdstc8()
	{StartCoroutine (fading8());}
	IEnumerator fading8()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 8;	
		matL.SetTexture("_Tex", stL[i]);	
		matR.SetTexture("_Tex", stR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +stL[i]);			
		print ("texture : " +stR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
		
		
	public void stp9()
	{Cmdstc9();}
	[Command]
	public void Cmdstc9()
	{StartCoroutine (fading9());}
	IEnumerator fading9()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 9;	
		matL.SetTexture("_Tex", stL[i]);	
		matR.SetTexture("_Tex", stR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +stL[i]);			
		print ("texture : " +stR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void stp10()
	{Cmdstc10();}
	[Command]
	public void Cmdstc10()
	{StartCoroutine (fading10());}
	IEnumerator fading10()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 10;	
		matL.SetTexture("_Tex", stL[i]);	
		matR.SetTexture("_Tex", stR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +stL[i]);			
		print ("texture : " +stR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void stp11()
	{Cmdstc11();}
	[Command]
	public void Cmdstc11()
	{StartCoroutine (fading11());}
	IEnumerator fading11()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 11;	
		matL.SetTexture("_Tex", stL[i]);	
		matR.SetTexture("_Tex", stR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +stL[i]);			
		print ("texture : " +stR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}




	///////////////////////////////////////////////////////////////////////////////////////////////////
	/////////////////////////////////	Manhattan images	///////////////////////////////////////////
	/// ///////////////////////////////////////////////////////////////////////////////////////////////

	
	public void man0()
	{Cmdmanstc0();}
	[Command]
	public void Cmdmanstc0()
	{StartCoroutine (manfading0());}
	IEnumerator manfading0()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 0;	
		matL.SetTexture("_Tex", mnL[i]);	
		matR.SetTexture("_Tex", mnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +mnL[i]);			
		print ("texture : " +mnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	
	
	public void man1()
	{Cmdmanstc1();}
	[Command]
	public void Cmdmanstc1()
	{StartCoroutine (manfading1());}
	IEnumerator manfading1()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 1;	
		matL.SetTexture("_Tex", mnL[i]);	
		matR.SetTexture("_Tex", mnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +mnL[i]);			
		print ("texture : " +mnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	
	
	public void man2()
	{Cmdmanstc2();}
	[Command]
	public void Cmdmanstc2()
	{StartCoroutine (manfading2());}
	IEnumerator manfading2()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 2;	
		matL.SetTexture("_Tex", mnL[i]);	
		matR.SetTexture("_Tex", mnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +mnL[i]);			
		print ("texture : " +mnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	
	
	public void man3()
	{Cmdmanstc3();}
	[Command]
	public void Cmdmanstc3()
	{StartCoroutine (manfading3());}
	IEnumerator manfading3()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 3;	
		matL.SetTexture("_Tex", mnL[i]);	
		matR.SetTexture("_Tex", mnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +mnL[i]);			
		print ("texture : " +mnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	
	
	public void man4()
	{Cmdmanstc4();}
	[Command]
	public void Cmdmanstc4()
	{StartCoroutine (manfading4());}
	IEnumerator manfading4()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 4;	
		matL.SetTexture("_Tex", mnL[i]);	
		matR.SetTexture("_Tex", mnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +mnL[i]);			
		print ("texture : " +mnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	
	
	public void man5()
	{Cmdmanstc5();}
	[Command]
	public void Cmdmanstc5()
	{StartCoroutine (manfading5());}
	IEnumerator manfading5()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 5;	
		matL.SetTexture("_Tex", mnL[i]);	
		matR.SetTexture("_Tex", mnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +mnL[i]);			
		print ("texture : " +mnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	
	
	public void man6()
	{Cmdmanstc6();}
	[Command]
	public void Cmdmanstc6()
	{StartCoroutine (manfading6());}
	IEnumerator manfading6()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 6;	
		matL.SetTexture("_Tex", mnL[i]);	
		matR.SetTexture("_Tex", mnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +mnL[i]);			
		print ("texture : " +mnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	
	
	public void man7()
	{Cmdmanstc7();}
	[Command]
	public void Cmdmanstc7()
	{StartCoroutine (manfading7());}
	IEnumerator manfading7()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 7;	
		matL.SetTexture("_Tex", mnL[i]);	
		matR.SetTexture("_Tex", mnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +mnL[i]);			
		print ("texture : " +mnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}


	///////////////////////////////////////////////////////////////////////////////////////////////////
	/////////////////////////////////	Bermondsey Works	///////////////////////////////////////////
	/// ///////////////////////////////////////////////////////////////////////////////////////////////


	public void ber0()
	{Cmdberstc0();}
	[Command]
	public void Cmdberstc0()
	{StartCoroutine (berfading0());}
	IEnumerator berfading0()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 0;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	
	public void ber1()
	{Cmdberstc1();}
	[Command]
	public void Cmdberstc1()
	{StartCoroutine (berfading1());}
	IEnumerator berfading1()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 1;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber2()
	{Cmdberstc2();}
	[Command]
	public void Cmdberstc2()
	{StartCoroutine (berfading2());}
	IEnumerator berfading2()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 2;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	
	public void ber3()
	{Cmdberstc3();}
	[Command]
	public void Cmdberstc3()
	{StartCoroutine (berfading3());}
	IEnumerator berfading3()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 3;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	
	public void ber4()
	{Cmdberstc4();}
	[Command]
	public void Cmdberstc4()
	{StartCoroutine (berfading4());}
	IEnumerator berfading4()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 4;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber5()
	{Cmdberstc5();}
	[Command]
	public void Cmdberstc5()
	{StartCoroutine (berfading5());}
	IEnumerator berfading5()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 5;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber6()
	{Cmdberstc6();}
	[Command]
	public void Cmdberstc6()
	{StartCoroutine (berfading6());}
	IEnumerator berfading6()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 6;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber7()
	{Cmdberstc7();}
	[Command]
	public void Cmdberstc7()
	{StartCoroutine (berfading7());}
	IEnumerator berfading7()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 7;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber8()
	{Cmdberstc8();}
	[Command]
	public void Cmdberstc8()
	{StartCoroutine (berfading8());}
	IEnumerator berfading8()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 8;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	
	public void ber9()
	{Cmdberstc9();}
	[Command]
	public void Cmdberstc9()
	{StartCoroutine (berfading9());}
	IEnumerator berfading9()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 9;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber10()
	{Cmdberstc10();}
	[Command]
	public void Cmdberstc10()
	{StartCoroutine (berfading10());}
	IEnumerator berfading10()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 10;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber11()
	{Cmdberstc11();}
	[Command]
	public void Cmdberstc11()
	{StartCoroutine (berfading11());}
	IEnumerator berfading11()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 11;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	public void ber12()
	{Cmdberstc12();}
	[Command]
	public void Cmdberstc12()
	{StartCoroutine (berfading12());}
	IEnumerator berfading12()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 12;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber13()
	{Cmdberstc13();}
	[Command]
	public void Cmdberstc13()
	{StartCoroutine (berfading13());}
	IEnumerator berfading13()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 13;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber14()
	{Cmdberstc14();}
	[Command]
	public void Cmdberstc14()
	{StartCoroutine (berfading14());}
	IEnumerator berfading14()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 14;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber15()
	{Cmdberstc15();}
	[Command]
	public void Cmdberstc15()
	{StartCoroutine (berfading15());}
	IEnumerator berfading15()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 15;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber16()
	{Cmdberstc16();}
	[Command]
	public void Cmdberstc16()
	{StartCoroutine (berfading16());}
	IEnumerator berfading16()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 16;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber17()
	{Cmdberstc17();}
	[Command]
	public void Cmdberstc17()
	{StartCoroutine (berfading17());}
	IEnumerator berfading17()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 17;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber18()
	{Cmdberstc18();}
	[Command]
	public void Cmdberstc18()
	{StartCoroutine (berfading18());}
	IEnumerator berfading18()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 18;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber19()
	{Cmdberstc19();}
	[Command]
	public void Cmdberstc19()
	{StartCoroutine (berfading19());}
	IEnumerator berfading19()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 19;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber20()
	{Cmdberstc20();}
	[Command]
	public void Cmdberstc20()
	{StartCoroutine (berfading20());}
	IEnumerator berfading20()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 20;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber21()
	{Cmdberstc21();}
	[Command]
	public void Cmdberstc21()
	{StartCoroutine (berfading21());}
	IEnumerator berfading21()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 21;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber22()
	{Cmdberstc22();}
	[Command]
	public void Cmdberstc22()
	{StartCoroutine (berfading22());}
	IEnumerator berfading22()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 22;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber23()
	{Cmdberstc23();}
	[Command]
	public void Cmdberstc23()
	{StartCoroutine (berfading23());}
	IEnumerator berfading23()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 23;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber24()
	{Cmdberstc24();}
	[Command]
	public void Cmdberstc24()
	{StartCoroutine (berfading24());}
	IEnumerator berfading24()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 24;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber25()
	{Cmdberstc25();}
	[Command]
	public void Cmdberstc25()
	{StartCoroutine (berfading25());}
	IEnumerator berfading25()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 25;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void ber26()
	{Cmdberstc26();}
	[Command]
	public void Cmdberstc26()
	{StartCoroutine (berfading26());}
	IEnumerator berfading26()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 26;	
		matL.SetTexture("_Tex", brL[i]);	
		matR.SetTexture("_Tex", brR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +brL[i]);			
		print ("texture : " +brR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}


	///////////////////////////////////////////////////////////////////////////////////////////////////
	/////////////////////////////////		City North		///////////////////////////////////////////
	/// ///////////////////////////////////////////////////////////////////////////////////////////////


	public void CityN0()
	{CmdCityNtc0();}
	[Command]
	public void CmdCityNtc0()
	{StartCoroutine (cityNfading0());}
	IEnumerator cityNfading0()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 0;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void CityN1()
	{CmdCityNtc1();}
	[Command]
	public void CmdCityNtc1()
	{StartCoroutine (cityNfading1());}
	IEnumerator cityNfading1()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 1;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	
	public void CityN2()
	{CmdCityNtc2();}
	[Command]
	public void CmdCityNtc2()
	{StartCoroutine (cityNfading2());}
	IEnumerator cityNfading2()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 2;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void CityN3()
	{CmdCityNtc3();}
	[Command]
	public void CmdCityNtc3()
	{StartCoroutine (cityNfading3());}
	IEnumerator cityNfading3()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 3;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void CityN4()
	{CmdCityNtc4();}
	[Command]
	public void CmdCityNtc4()
	{StartCoroutine (cityNfading4());}
	IEnumerator cityNfading4()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 4;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void CityN5()
	{CmdCityNtc5();}
	[Command]
	public void CmdCityNtc5()
	{StartCoroutine (cityNfading5());}
	IEnumerator cityNfading5()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 5;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void CityN6()
	{CmdCityNtc6();}
	[Command]
	public void CmdCityNtc6()
	{StartCoroutine (cityNfading6());}
	IEnumerator cityNfading6()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 6;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	
	public void CityN7()
	{CmdCityNtc7();}
	[Command]
	public void CmdCityNtc7()
	{StartCoroutine (cityNfading7());}
	IEnumerator cityNfading7()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 7;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	
	public void CityN8()
	{CmdCityNtc8();}
	[Command]
	public void CmdCityNtc8()
	{StartCoroutine (cityNfading8());}
	IEnumerator cityNfading8()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 8;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	
	public void CityN9()
	{CmdCityNtc9();}
	[Command]
	public void CmdCityNtc9()
	{StartCoroutine (cityNfading9());}
	IEnumerator cityNfading9()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 9;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	
	public void CityN10()
	{CmdCityNtc10();}
	[Command]
	public void CmdCityNtc10()
	{StartCoroutine (cityNfading10());}
	IEnumerator cityNfading10()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 10;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void CityN11()
	{CmdCityNtc11();}
	[Command]
	public void CmdCityNtc11()
	{StartCoroutine (cityNfading11());}
	IEnumerator cityNfading11()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 11;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void CityN12()
	{CmdCityNtc12();}
	[Command]
	public void CmdCityNtc12()
	{StartCoroutine (cityNfading12());}
	IEnumerator cityNfading12()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 12;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	
	public void CityN13()
	{CmdCityNtc13();}
	[Command]
	public void CmdCityNtc13()
	{StartCoroutine (cityNfading13());}
	IEnumerator cityNfading13()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 13;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void CityN14()
	{CmdCityNtc14();}
	[Command]
	public void CmdCityNtc14()
	{StartCoroutine (cityNfading14());}
	IEnumerator cityNfading14()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 14;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}


	public void CityN15()
	{CmdCityNtc15();}
	[Command]
	public void CmdCityNtc15()
	{StartCoroutine (cityNfading15());}
	IEnumerator cityNfading15()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 15;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void CityN16()
	{CmdCityNtc16();}
	[Command]
	public void CmdCityNtc16()
	{StartCoroutine (cityNfading16());}
	IEnumerator cityNfading16()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 16;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void CityN17()
	{CmdCityNtc17();}
	[Command]
	public void CmdCityNtc17()
	{StartCoroutine (cityNfading17());}
	IEnumerator cityNfading17()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 17;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	
	public void CityN18()
	{CmdCityNtc18();}
	[Command]
	public void CmdCityNtc18()
	{StartCoroutine (cityNfading18());}
	IEnumerator cityNfading18()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 18;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
	
	public void CityN19()
	{CmdCityNtc19();}
	[Command]
	public void CmdCityNtc19()
	{StartCoroutine (cityNfading19());}
	IEnumerator cityNfading19()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 19;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}

	public void CityN20()
	{CmdCityNtc20();}
	[Command]
	public void CmdCityNtc20()
	{StartCoroutine (cityNfading20());}
	IEnumerator cityNfading20()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 20;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}


	public void CityN21()
	{CmdCityNtc21();}
	[Command]
	public void CmdCityNtc21()
	{StartCoroutine (cityNfading21());}
	IEnumerator cityNfading21()
	{for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{c.r = a;c.g = a;c.b = a;		
			matL.SetColor ("_Tint", c);			
			matR.SetColor ("_Tint", c);			yield return null;}
		int i = 21;	
		matL.SetTexture("_Tex", cnL[i]);	
		matR.SetTexture("_Tex", cnR[i]);

		cams.transform.eulerAngles = new Vector3(0,0,0);
		print ("texture : " +cnL[i]);			
		print ("texture : " +cnR[i]);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{c.r = b;c.g = b;c.b = b;
			matL.SetColor ("_Tint", c);
			matR.SetColor ("_Tint", c);			yield return null;
		}}
}