using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBottomMovement : MonoBehaviour {

	private Vector3 target = new Vector3(1.58f , 1f , 0f);
	public float speed;
	void Start () {
		
	}
	

	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, target, Time.deltaTime * speed);
		if (transform.position == target && target.y != 1f)
			target.y = 1f;
		else if (transform.position == target && target.y == 1f)
			target.y = 0.3f;
	}
}
