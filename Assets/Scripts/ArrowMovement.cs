using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour {

	private Vector3 target = new Vector3(0.73f , 0.51f , 0f);
	public float speed;
	void Start () {
		
	}
	

	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, target, Time.deltaTime * speed);
		if (transform.position == target && target.y != 0.51f)
			target.y = 0.51f;
		else if(transform.position == target && target.y == 0.51f)
			target.y = 1.21f;
	}
}
