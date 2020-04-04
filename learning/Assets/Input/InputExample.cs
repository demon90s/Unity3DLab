using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputExample : MonoBehaviour {

	// Input.GetAxis
	// 返回虚拟坐标轴的值，范围是-1...1
	// 按下键盘的上下左右键即可获取输入
	// PS: 把虚拟坐标轴想象成一个摇杆，最大摇的范围是1
	void Test_GetAxis()
	{
		// 上下(1 ~ -1)
		float v_axis = Input.GetAxis("Vertical");

		// 左右(-1 ~ 1)
		float h_axis = Input.GetAxis("Horizontal");

		if (v_axis != 0 || h_axis != 0) {
			string message = string.Format ("v_axis: {0}, h_axis: {1}", v_axis, h_axis);
			Debug.Log (message);
		}

		// 沿着Y轴旋转光照
		float rotation_speed = 100.0f;
		float rotation = h_axis * rotation_speed * Time.deltaTime;
		GameObject light = GameObject.Find ("Directional Light");
		light.transform.Rotate (0, rotation, 0);
	}

	// Input.GetKey 当某个键位被按着
	// Input.GetKeyDown 当某个键位被按下
	// Input.GetKeyUp 当某个键位被抬起
	void Test_Key()
	{
		if (Input.GetKey (KeyCode.UpArrow)) {
			Debug.Log ("[GetKey] 键盘上方向键被按着ing ...");
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			Debug.Log ("[GetKey] 键盘下方向键被按着ing ...");
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			Debug.Log ("[GetKeyDown] 键盘空格键被按下");
		}

		if (Input.GetKeyUp (KeyCode.Space)) {
			Debug.Log ("[GetKeyUp] 键盘空格键抬起");
		}
	}

	// Input.GetButton 返回 true 当某个虚拟按键被按着
	// Input.GetButtonDown 返回 true 当某个虚拟按键被按下
	void Test_Button()
	{
		// Fire1 对应摇杆0号键或鼠标左键
		/* if (Input.GetButton ("Fire1")) {
			Debug.Log ("[GetButton] Fire1");
		} */

		if (Input.GetButtonDown("Fire1")) {
			Debug.Log("[GetButtonDown] Fire1");
		}
	}

	// mousePosition
	// public static Vector3 mousePosition
	// 返回当前鼠标的像素坐标，只读
	Vector3 mouse_position;
	void Test_mousePosition() {
		mouse_position = Input.mousePosition;
		GUI.Label (new Rect (10, 10, 300, 30), "mouse screen point: " + mouse_position);
	}

	void OnGUI() {
		Test_mousePosition ();
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Test_Button();
	}
}
