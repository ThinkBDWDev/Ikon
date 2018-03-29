using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using WindowsInput;

public class NFC_OCL_Test : MonoBehaviour {

	public InputField input;
	public Material vrL;
	public Material vrR;
	public Texture[] txL = new Texture[2];
	public Texture[] txR = new Texture[2];
	public string[] st = new string[2];
	public Color def;
	private Color c;
	private int f;


	void Start () {

		input.ActivateInputField();
		//vrL.SetTexture("_Tex", txL[0]);	
		//vrR.SetTexture("_Tex", txR[0]);

	}
	
	void Update () 
	{
		if (input.text == st[0] || Input.GetKeyDown(KeyCode.LeftArrow))
		{
			f= 0;
			Cmdstc0();
			Debug.Log("black");
			Reset();
			InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
		}

		if (input.text == st[1] || Input.GetKeyDown(KeyCode.RightArrow))
		{
			f= 1;
			Cmdstc0();
			Debug.Log("red");
			Reset();
			InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
		}
	}

	public void Reset()
	{
		input.text = "";
		input.ActivateInputField();
	}

	private void Cmdstc0()
	{
		StartCoroutine (fading());
	}
	IEnumerator fading()
	{
		for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
		{
			c.r = a;c.g = a;c.b = a;		
			vrL.SetColor ("_Tint", c);			
			vrR.SetColor ("_Tint", c);			yield return null;
		}
		
		vrL.SetTexture("_Tex", txL[f]);	
		vrR.SetTexture("_Tex", txR[f]);
		print ("texture : " +txL[f]);			
		print ("texture : " +txR[f]);

		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{
			c.r = b;c.g = b;c.b = b;
			vrL.SetColor ("_Tint", c);
			vrR.SetColor ("_Tint", c);			yield return null;
		}
	}




}
