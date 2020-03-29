using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	void DrawRayForTest()
	{
		Vector3 forward = transform.TransformDirection (Vector3.up) * 10;
		Debug.DrawRay (transform.position, forward, Color.red);
	}

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		Test_Rotate ();
		//Test_RotateAround();
	}

	// Rotate: 在某个轴上旋转一个角度，默认采用 local 坐标系
	void Test_Rotate()
	{
		//Vector3 rotate_y = new Vector3 (0, 45, 0); // 以每秒45度绕y轴旋转
		//transform.Rotate (rotate_y * Time.deltaTime);

		Vector3 rotate_xyz = new Vector3 (45, 45, 45);
		transform.Rotate (rotate_xyz * Time.deltaTime);
	}

	// RotateAround: 围绕某个点旋转
	void Test_RotateAround()
	{
		DrawRayForTest ();

		transform.RotateAround (this.transform.position, Vector3.up, 45 * Time.deltaTime);
	}
}
