using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeExample : MonoBehaviour {
	// Time.time
	// 返回当前帧起始的时间，游戏开始时时间为0
	void Test_time()
	{
		Debug.Log ("current frame time: " + Time.time);
	}

	// Time.deltaTime
	// 上一帧流逝的时间

	// Time.timeScale
	// 时间流逝的尺度，可以用于慢动作（或暂停）
	// 当值为1.0时，如同真实时间，当值为0.5则比真实时间慢两倍
	// 当值为0时，游戏暂停

	void Test_deltaTime_timeScale() {
		Vector3 rotate_y = new Vector3 (0, 45, 0); // 以每秒45度绕y轴旋转
		transform.Rotate (rotate_y * Time.deltaTime);

		// 若按下了鼠标左键，游戏放慢50%
		if (Input.GetButton ("Fire1")) {
			Time.timeScale = 0.5f;
		} else {
			Time.timeScale = 1.0f;
		}
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//Test_time ();
		Test_deltaTime_timeScale();
	}
}
