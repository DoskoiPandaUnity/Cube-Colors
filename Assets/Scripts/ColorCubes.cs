using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCubes : MonoBehaviour {
	public bool main = false , right = false;
	private static Color color;
	void Awake(){
		if(main)
		color = new Vector4 (Random.Range (0.1f, 1f), Random.Range (0.1f, 1f), Random.Range (0.1f, 1f), 1);
	}
	void Start(){
		if (main || right)
			GetComponent<Renderer> ().material.color = color;
		else
			GetComponent<Renderer> ().material.color = new Vector4 (color.r + Random.Range (0.1f, 0.5f), color.g + Random.Range (0.1f, 0.5f), color.b + Random.Range (0.1f, 0.5f), color.a);
	}
	

}
