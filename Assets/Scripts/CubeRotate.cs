using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour {
	public float speed;
	public float tilt;
	private Vector3 target = new Vector3(0 , 2.24f , 0);
	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, target, Time.deltaTime * speed);
		if (transform.position == target && target.y != 2.24f)
			target.y = 2.24f;
		else if (transform.position == target && target.y == 2.24f)
			target.y = 0.52f;
		transform.Rotate (new Vector3 (0, 26, 0) * Time.deltaTime * tilt);
	}
}
