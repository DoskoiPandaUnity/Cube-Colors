using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {
	public GameObject mon , mof;
	public Sprite layer_blue, layer_red;
	void Start(){
		if (gameObject.name == "Music") {
			if (PlayerPrefs.GetString ("Music") == "Off") {
				mon.SetActive (false);
				mof.SetActive (true);
			} else {
				mon.SetActive (true);
				mof.SetActive (false);
			}
				
		}
	}
	void OnMouseDown () {
		GetComponent <SpriteRenderer> ().sprite = layer_red;
	}

	void OnMouseUp () {
		GetComponent <SpriteRenderer> ().sprite = layer_blue;
	}
	void OnMouseUpAsButton(){
		if (PlayerPrefs.GetString ("Music") == "On")
			GameObject.Find ("ClickAudio").GetComponent<AudioSource> ().Play ();
		switch(gameObject.name){
		case "Play":
			Application.LoadLevel("Play");
			break;
		case "Raiting":
			Application.OpenURL ("https://play.google.com/store/apps/details?id=com.KindHeart.CubeColors");
			break;
		case "Restart":
			Application.LoadLevel ("Play");
			break;
		case "Home":
			Application.LoadLevel ("Title Game");
			break;
		case "VK":
			Application.OpenURL ("https://vk.com/id228582187");
			break;
		case "Help":
			Application.LoadLevel ("Help");
			break;
		case "Close":
			Application.LoadLevel ("Title Game");
			break;
		case "Music":
			if (PlayerPrefs.GetString ("Music") != "Off") {
				PlayerPrefs.SetString ("Music", "Off");
				mon.SetActive (false);
				mof.SetActive (true);
			} else {
				PlayerPrefs.SetString ("Music", "On");
				mon.SetActive (true);
				mof.SetActive (false);
			}
			break;
		}
	}
}