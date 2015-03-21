using UnityEngine;
using System.Collections;

public class RenderCameraTexture : MonoBehaviour {

	public static Texture2D 	renderedTexture;
	public Material		targetMaterial;

	public void Awake()
	{
		renderedTexture = new Texture2D (512, 512);
		targetMaterial.mainTexture = renderedTexture;
	}

	public void OnPostRender()
	{
		renderedTexture.ReadPixels(new Rect(0, 0, 512, 512), 0, 0);	// Screen.width, Screen.height
		renderedTexture.Apply ();
	}
}
