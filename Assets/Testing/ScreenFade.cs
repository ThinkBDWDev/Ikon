using UnityEngine;
using System.Collections;

public class ScreenFade : MonoBehaviour {
public Material mat;
public Color def;
private Color c;
public Texture tex1;
public Texture tex2;


void Start()
{
		mat.SetColor ("_Tint", def);
		mat.SetTexture ("_Tex",tex2);
}

public void fade()
	{
		StartCoroutine (fading());
	}
	
		IEnumerator fading()
		{
		for (float a = 0.5f; a >= 0.0f; a -= 0.01f) 
			{
				c.r = a;
				c.g = a;
				c.b = a;
				mat.SetColor ("_Tint", c);
				yield return null;
			}
		mat.SetTexture ("_Tex",tex1);
		for (float b = 0.0f; b <= 0.5f; b += 0.01f) 
		{
			c.r = b;
			c.g = b;
			c.b = b;
			mat.SetColor ("_Tint", c);
			yield return null;
		}
		
	}
}

