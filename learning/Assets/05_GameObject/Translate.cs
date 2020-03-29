using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour {

	public float speed = 10.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Move ();
	}

	void Move()
	{
		float h_axis = Input.GetAxis ("Horizontal");
		float v_axis = Input.GetAxis ("Vertical");

		transform.Translate (new Vector3 (h_axis, 0, v_axis) * speed * Time.deltaTime);
	}
}
