using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	public Color defColor , newColor;
	private Color  lastcolor;
	public GameObject MainCube;
	void Start(){
		lastcolor = MainCube.GetComponent<Renderer> ().material.color;
	}
	void Update(){
		if (MainCube.GetComponent<Renderer> ().material.color != lastcolor) {
			lastcolor = MainCube.GetComponent<Renderer> ().material.color;
			transform.position = new Vector3(0, transform.position.y, 0);
			GetComponent<Renderer> ().material.color = defColor;
		}
		if (!MainCube.GetComponent<GameCntrl>().lose) {
			if(transform.position.x < -0.8f)
			GetComponent<Renderer> ().material.color = Color.Lerp (GetComponent<Renderer> ().material.color, newColor, Time.deltaTime);
			if (transform.position.x < -5.6f)
				Destroy (gameObject);
			transform.position -= new Vector3 (0.03f, 0, 0);
		}
	}
	void OnDestroy(){
		if(MainCube)
		MainCube.GetComponent<GameCntrl>().lose = true;
	}
}
