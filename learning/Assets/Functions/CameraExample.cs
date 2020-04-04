using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraExample : MonoBehaviour {
	public GameObject camera_obj;

	// 一个跟随物体移动的例子
	private Vector3 offset; // camera_obj 和 following_obj 之间的初始偏移量
	void Move()
	{
		float h_axis = Input.GetAxis ("Horizontal");
		float v_axis = Input.GetAxis ("Vertical");
		transform.Translate (new Vector3 (h_axis, 0, v_axis) * 10.0f * Time.deltaTime);

		camera_obj.transform.position = transform.position + offset;
	}

	// 一个看着物体移动的例子（自身会旋转）
	void LookAtExample()
	{
		float h_axis = Input.GetAxis ("Horizontal");
		float v_axis = Input.GetAxis ("Vertical");
		transform.Translate (new Vector3 (h_axis, 0, v_axis) * 10.0f * Time.deltaTime);

		camera_obj.transform.LookAt (transform.position);
	}

	/////////////////////////////////////////////////////////

	// Use this for initialization
	void Start () {
		offset = camera_obj.transform.position - transform.position;
	}

	// Update is called once per frame
	void Update () {
		//Move ();
		LookAtExample();
	}
}
