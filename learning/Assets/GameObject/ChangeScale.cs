using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour {

	public float max_scale = 5.0f;
	public float speed = 1.0f;

	// 每帧变大，直到最大
	void Test_localScale()
	{
		if (transform.localScale.x < max_scale) {
			transform.localScale += speed * Time.deltaTime * (new Vector3 (1, 1, 1));
			if (transform.localScale.x > max_scale){
				transform.localScale = new Vector3 (max_scale, max_scale, max_scale);
			}
		}
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Test_localScale ();
	}
}
